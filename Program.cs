
using Microsoft.AspNetCore.RateLimiting;
using StreamingOptionsAPI.AutoMapper;
using StreamingOptionsAPI.Exceptions;
using StreamingOptionsAPI.Model;
using System.Globalization;
using System.Threading.RateLimiting;

namespace StreamingOptionsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var myAllowSpecificOrigins = "_myAllowSpecificOrigins";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(myAllowSpecificOrigins,
                                      policy =>
                                      {
                                          policy.WithOrigins("http://wheretowatch.com.br")
                                                              .AllowAnyHeader()
                                                              .AllowAnyMethod();
                                      });
            });


            builder.WebHost.ConfigureKestrel(options =>
            {
                options.ListenAnyIP(6323); 
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(typeof(ConfigurationMapping));
            builder.Services.AddExceptionHandler<AppExceptionHandler>();

            var myOptions = new MyRateLimitOptions();
            builder.Configuration.GetSection(MyRateLimitOptions.MyRateLimit).Bind(myOptions);
            var fixedPolicy = "fixed";

            builder.Services.AddRateLimiter(_ => _
                .AddFixedWindowLimiter(policyName: fixedPolicy, options =>
                {
                    options.PermitLimit = myOptions.PermitLimit;
                    options.Window = TimeSpan.FromSeconds(myOptions.Window);
                })
                .OnRejected = async (context, cancellationToken) =>
                {
                    if (context.Lease.TryGetMetadata(MetadataName.RetryAfter, out var retryAfter))
                    {
                        context.HttpContext.Response.Headers.RetryAfter =
                            ((int)retryAfter.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo);
                    }

                    context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                    await context.HttpContext.Response.WriteAsync("Too many requests. Please try again later.", cancellationToken);
                });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseExceptionHandler(_ => { });
            

            app.UseAuthorization();
            app.UseCors(myAllowSpecificOrigins);

            app.UseRateLimiter();
            app.MapDefaultControllerRoute().RequireRateLimiting(fixedPolicy);

            app.MapControllers();

            app.Run();
        }
    }
}
