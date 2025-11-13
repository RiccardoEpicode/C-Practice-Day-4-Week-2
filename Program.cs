namespace C__Day_3_ASP.NET_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddControllersWithViews(); // Adds MVC pattern support (Controllers + Views)

            var app = builder.Build(); // Creates the web application instance (ready to configure middleware)

            
            if (!app.Environment.IsDevelopment()) // Configure the HTTP request pipeline.
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles(); // Enables usage of static files such as images , CSS and Javascript from the www folder

            app.UseRouting(); // Enables Routing - So that the requests are redirected to the appropriate endpoint

            app.UseAuthorization(); // Enables users to access secured resources

            // It sets up the default route pattern, and maps it to the home controller and its index
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Home}/{id?}");

            app.Run(); // This line starts the application and listens to the http request
        }
    }
}
