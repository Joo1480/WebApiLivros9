using Microsoft.Extensions.Hosting;
using System.Net;
using System.Text.Json;
using System.Xml;
using WebApiLivros9.API.Errors;

namespace WebApiLivros9.API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception Ex)
            {
                _logger.LogError(Ex, Ex.Message);
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var response = _env.IsDevelopment() ? 
                    new ApiException(context.Response.StatusCode.ToString(), Ex.Message, Ex.StackTrace.ToString()) :
                    new ApiException(context.Response.StatusCode.ToString(), Ex.Message, "Internal server erro");

                var options = new JsonSerializerOptions { PropertyNamingPolicy =  JsonNamingPolicy.CamelCase };
                
                var json = JsonSerializer.Serialize(response, options);
                await context.Response.WriteAsync(json);
            }
        }
    }
}
