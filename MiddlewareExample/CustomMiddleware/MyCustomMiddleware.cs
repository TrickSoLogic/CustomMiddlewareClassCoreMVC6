namespace MiddlewareExample.CustomMiddleware
{
    public class CustomMiddlewareClassCoreMVC6 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("My Custom Middleware - Starts");
            await next(context);
            await context.Response.WriteAsync("My Custom Middleware - Ends");
        }
    }
}
