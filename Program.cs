using Holding_management.Repository;
using Holding_managment.Data;
using Holding_managment.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Holding_managment
{
    public class Program
    {
        public IConfiguration Configuration { get; }
       // private string _connectionString;
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

           var _connectionString =builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContextPool<db_holdingContext>(options =>
             options.UseMySql(
                        _connectionString,
                        ServerVersion.AutoDetect(_connectionString)
            ));

            builder.Services.AddSession();

          //  builder.Services.AddDbContext<db_holdingContext>(option=>option.UseMySql(ServerVersion.AutoDetect("DefaultConnection")));
            builder.Services.AddScoped<IAuth,AuthRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();   
            app.UseCookiePolicy();  
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Auth}/{action=Login}/{id?}");

            app.Run();
        }
    }
}