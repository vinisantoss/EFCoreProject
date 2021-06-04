using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft;
using SmartSchool.API.Data.Context;
using SmartSchool.API.Ioc;

namespace SmartSchool.API
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
            ApplicationDependencyResolver.DependencyResolver(services);
            var configuration = ApplicationDependencyResolver.Configuration;

            /*
            var migrationAssembly = typeof(Startup)
                .GetTypeInfo()
                .Assembly
                .GetName().Name;

            services.AddDbContext<Context>(
                options => options.UseSqlServer(configuration["ConnectionStrings:SqlServer"], sql =>
                sql.MigrationsAssembly(migrationAssembly))
                );*/

            services.AddDbContext<SmartSchoolContextSqlite>
                (
                    context => context.UseSqlite(configuration["ConnectionStrings:Sqlite"])
                );


            services.AddControllers()
                    .AddNewtonsoftJson(
                        options => options.SerializerSettings.ReferenceLoopHandling =
                        Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
