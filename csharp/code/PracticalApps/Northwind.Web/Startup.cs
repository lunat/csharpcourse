namespace Northwind.Web;
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages();
    }

    public void Configure(
        IApplicationBuilder app,
        IWebHostEnvironment env)
    {
        if (!env.IsDevelopment())
        {
            app.UseHsts();
        }

        app.UseRouting(); // start endpoint routing
        app.UseHttpsRedirection();
        app.UseDefaultFiles(); // index.html | default.html ...
        app.UseStaticFiles(); // to use wwwroot
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
            endpoints.MapGet("/hello", () => "Hello World!");
        });
        //app.MapGet("/", () => "Hello World!");

    }
}
