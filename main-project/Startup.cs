using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueMuromez.Interfaces;
using TrueMuromez.Models;
using TrueMuromez.Repos;

namespace TrueMuromez
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        [Obsolete]
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {           
            services.AddMvcCore();
            services.AddMvc(option => option.EnableEndpointRouting = false); //тут нашаманил

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddScoped<IGenericRepos<Product>, GenericRepos<Product>>();
            services.AddScoped<IGenericRepos<ProductContent>, GenericRepos<ProductContent>>();
            services.AddScoped<IGenericRepos<Training>, GenericRepos<Training>>();
            services.AddScoped<IGenericRepos<TrainingCategory>, GenericRepos<TrainingCategory>>();
            services.AddScoped<IGenericRepos<TrainingContent>, GenericRepos<TrainingContent>>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();


            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDbContext content = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Training}/{action=TrainingView}/{id?}");
            });
        }
    }
}
