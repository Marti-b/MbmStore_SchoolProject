using MbmStore.Models;
using MbmStore.Models.ViewModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace MbmStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Catalogue/{category}/Page{page:int}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index"
                    }); 
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Page{page:int}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    });
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Catalogue/{category}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    });
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    });

                endpoints.MapControllerRoute(
                    name: "pagination",
                    pattern: "Catalogue/Page{page}",
                    defaults: new { Controller = "Catalogue", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}