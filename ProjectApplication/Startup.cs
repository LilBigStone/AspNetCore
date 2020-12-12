using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectApplication.Data;
using ProjectApplication.Data.Interfaces;
using ProjectApplication.Data.Models;
using ProjectApplication.Data.Repository;
using ProjectApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApplication.Hub;

namespace ProjectApplication
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
            services.AddDbContext<appDBcontent>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("DefaultConnection")));

            
            services.AddTransient<IAllMilks, CarRepository>();
            services.AddTransient<IMilkCategory, CategoryRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IAllOrders, Ordersrepository>();
            services.AddScoped(sp => ShopCart.GetCart(sp));
            
            services.AddIdentity<UserModel, IdentityRole>(
                    options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<appDBcontent>()
                .AddTokenProvider<DataProtectorTokenProvider<UserModel>>(TokenOptions.DefaultProvider).AddDefaultUI();

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           
            if (env.IsDevelopment())
            {
                app.UseSession();
                app.UseStatusCodePages();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            using (var scope = app.ApplicationServices.CreateScope())
            {
                appDBcontent content = scope.ServiceProvider.GetRequiredService<appDBcontent>();
                DbObjects.Initial(content);
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
                endpoints.MapRazorPages();
                endpoints.MapHub<ChatHub>("/chat");
            });

        }
    }
}
