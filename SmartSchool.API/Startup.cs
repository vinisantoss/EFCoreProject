using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SmartSchool.API.Data.Context;
using SmartSchool.API.Ioc;
using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

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

            services.AddDbContext<SmartSchoolContextSqlServer>(options => 

                options.UseSqlServer(configuration["ConnectionStrings:SqlServer"])
            );

            //services.AddDbContext<SmartSchoolContextSqlite>
            //    (
            //        context => context.UseSqlite(configuration["ConnectionStrings:Sqlite"])
            //    );

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV"; //formato da versao
                options.SubstituteApiVersionInUrl = true; //permite colocar na rota a versao da api e disponibilizacao dos metodos
            })
            .AddApiVersioning(options => {
                options.AssumeDefaultVersionWhenUnspecified = true;//quando não definir a versao, a versao padrão sera a proxima propriedade
                options.DefaultApiVersion = new ApiVersion(1, 0); //versao default setada acima
                options.ReportApiVersions = true;
            });

            services.AddControllers()
                    .AddNewtonsoftJson(
                        options => options.SerializerSettings.ReferenceLoopHandling =
                        Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            var apiProviderDescription = services.BuildServiceProvider()
                                                 .GetService<IApiVersionDescriptionProvider>(); //provider para pegar as versoes dentro das rotas que a api tem.

            

            services.AddSwaggerGen(options =>
            {

                foreach (var description in apiProviderDescription.ApiVersionDescriptions)
                {
                    options.SwaggerDoc(
                    description.GroupName,
                    new OpenApiInfo
                    {
                        Title = "SmartSchool API",
                        Version = description.ApiVersion.ToString(),
                        TermsOfService = new Uri("http://seutermodeuso.com"),
                        Description = "WebAPI acadêmica",
                        License = new OpenApiLicense
                        {
                            Name = "SmartSchool API License",
                            Url = new Uri("http://minhalicenca.com")
                        },
                        Contact = new OpenApiContact
                        {
                            Name = "Vinicius Santos",
                            Email = "",
                            Url = new Uri("http://meusite.com.br")
                        }
                    });
                }

                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFileFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                options.IncludeXmlComments(xmlCommentsFileFullPath);
            });
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider apiProviderDescription)

        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger()
                .UseSwaggerUI(options =>
                {
                    foreach (var description in apiProviderDescription.ApiVersionDescriptions)
                    {
                        options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
                    }
                    options.RoutePrefix = "";
                });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
