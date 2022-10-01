using Mynda.API.CustomMiddleware;
using Serilog;

namespace Mynda.API.CustomMiddleware
{
    public class GlobalMiddleware
    {
        private readonly RequestDelegate next;

        public GlobalMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var start = DateTime.UtcNow;
            await httpContext.Response.WriteAsync("Our Middleware");
            await next(httpContext);
            Log.Information($"Request {httpContext.Request.Path}: {(DateTime.UtcNow - start).TotalMilliseconds}ms");
        }
    }
}

public static class GlobalExtensions
{
    public static IApplicationBuilder UseMynda(this IApplicationBuilder app)
    {
        return app.UseMiddleware<GlobalMiddleware>();
    }

    /*public static void AddMyndaService(this IServiceCollection services)
    {
        services.AddTransient<I>();
    }*/
}
