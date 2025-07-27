using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapGet("/", static async context =>
{
    context.Response.ContentType = "text/plain;charset=utf-8";
    await context.Response.WriteAsync("Привет Мир!!!!!", Encoding.UTF8);
});
  

app.Run();
