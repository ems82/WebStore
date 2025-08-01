using System.Text;

var builder = WebApplication.CreateBuilder(args);
//var greetings = builder.Configuration["CustomGreetings"];
builder.Services.AddMvc();

builder.Services.AddRazorPages();
var app = builder.Build();


//app.MapGet("/", () => "Hello World!");
app.MapGet("/greeting", async context =>
{
    context.Response.ContentType = "text/plain;charset=utf-8";
    await context.Response.WriteAsync("Привет Мир!!!!!" + ":\n" + builder.Configuration["CustomGreetings"], Encoding.UTF8);
});
app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}");  // http://localhost:5000/Home/Index/id

app.UseDefaultFiles();
app.UseStaticFiles();

//  app.UseMvc();

app.Run();
