using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Auth.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Auth.Data.Repositories.UserRepository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Auth.Data.Repositories.PlantRepository;
using System.Reflection;
using Auth.Data.Profiles;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace Auth.Web
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
            services.AddControllersWithViews(o => o.Filters.Add(new AuthorizeFilter()));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPlantRepository, PlantRepository>();
            services.AddAutoMapper(typeof(Startup).GetTypeInfo().Assembly,
            typeof(PlantProfile).GetTypeInfo().Assembly);
            services.AddDbContext<AuthDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                assembly => assembly.MigrationsAssembly(typeof(AuthDbContext).Assembly.FullName)));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            /*services.AddAuthentication(o => {
                o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                //o.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
            })
                .AddCookie()
                //.AddCookie(ExternalAuthenticationDefaults.AuthenticationScheme)
                .AddGoogle(o =>
                {
                    o.SignInScheme = ExternalAuthenticationDefaults.AuthenticationScheme;
                    o.ClientId = Configuration["Google:ClientId"];
                    o.ClientSecret = Configuration["Google:ClientSecret"];
                }); */

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Plant}/{action=Index}/{id?}");
            });
        }
    }
}
