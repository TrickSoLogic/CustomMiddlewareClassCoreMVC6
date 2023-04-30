using MiddlewareExample.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<CustomMiddlewareClassCoreMVC6>();
var app = builder.Build();



//middlware 1
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("From Midleware 1");
    await next(context);
});

//middleware 2
app.UseMiddleware<CustomMiddlewareClassCoreMVC6>();


//middleware 3
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("From Middleware 3");
});


app.Run();
