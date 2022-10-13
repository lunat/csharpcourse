//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.Run();

using Northwind.Web;

Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>();
    })
    .Build()
    .Run();


Console.WriteLine("This line will be executed after the web server has stopped");