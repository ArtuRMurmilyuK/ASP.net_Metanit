var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run(async (context) =>
{
    var response = context.Response;
    response.ContentType = "text/html; charset=utf-8";
    await response.WriteAsync("<h2>Hello Metanit.com</h2><h3>Welcome to Asp.net</h3>");
});
app.Run();