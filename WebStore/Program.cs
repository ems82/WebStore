using System.Text;

var builder = WebApplication.CreateBuilder(args);
var logLevel = builder.Configuration["CustomGreetings"];

builder.Services.AddRazorPages();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/plain;charset=utf-8";
    await context.Response.WriteAsync("Привет Мир!!!!!" + ":\n" + logLevel, Encoding.UTF8);
});
  

app.Run();
