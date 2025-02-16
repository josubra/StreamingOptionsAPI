
using Microsoft.AspNetCore.RateLimiting;
using StreamingOptionsAPI.AutoMapper;
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

            builder.WebHost.ConfigureKestrel(options =>
            {
                options.ListenAnyIP(6323); 
            });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(typeof(ConfigurationMapping));

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

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.UseRateLimiter();
            app.MapDefaultControllerRoute().RequireRateLimiting(fixedPolicy);

            app.MapControllers();

            app.Run();
        }
    }
}
