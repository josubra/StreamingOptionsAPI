using Microsoft.AspNetCore.Diagnostics;
using StreamingOptionsAPI.Controllers;
using System.Text.Json;

namespace StreamingOptionsAPI.Exceptions
{
    public class AppExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<AppExceptionHandler> _logger;
        public AppExceptionHandler(ILogger<AppExceptionHandler> logger) => _logger = logger;
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var response = new ErrorResponse()
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                ExceptionMessage = exception.Message,
                StackTrace = exception.StackTrace,
                Title = "Someting went wrong"
            };
            _logger.LogError(JsonSerializer.Serialize(response));
            await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
            return true;
        }
    }
}
