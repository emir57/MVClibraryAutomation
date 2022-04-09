using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using libraryMVC_.Data;
using libraryMVC.Profiles;
using libraryMVC.Entities;
using Microsoft.AspNetCore.Identity;
using libraryMVC.Data.DataSeed;
using libraryMVC.Controllers;

namespace site
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
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("AppDbContext")));
            services.AddIdentity<Uye, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            services.AddAutoMapper(typeof(LibraryProfile));

            services.AddScoped<UserManager<Uye>>();
            services.AddScoped<SignInManager<Uye>>();
            services.AddScoped<RoleManager<IdentityRole>>();

            services.Configure<IdentityOptions>(opt =>
            {

            });
            services.ConfigureApplicationCookie(opt =>
            {
                opt.AccessDeniedPath = "Home/UnAuthorized";
            });
            services.AddMvcCore(opt =>
            {
                opt.Filters.Add(typeof(CustomActionFilter));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                DataSeed.Seed(app);
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Hesap}/{action=GirisYap}/{id?}");
            });
        }
    }
}
