using DL;
using Microsoft.EntityFrameworkCore;

namespace ProyectoEntropy
{
    public class StartUp
    {

        public WebApplication InicializarApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app;

        }

        public  void  ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllersWithViews();
            var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<EmployeeContext>(opciones => opciones.UseSqlServer(ConnectionString));
            var app = builder.Build();
        }

        public  void Configure(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

        }


    }
}
