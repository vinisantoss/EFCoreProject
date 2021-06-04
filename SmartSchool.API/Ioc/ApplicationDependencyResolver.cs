using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartSchool.API.AutoMapper;
using SmartSchool.API.Data.Repository;
using SmartSchool.API.Data.Repository.Interfaces;
using System;

namespace SmartSchool.API.Ioc
{
    public static class ApplicationDependencyResolver
    {
        public static IConfiguration Configuration;
        private const string fileSettings = "appsettings.json";
        static ApplicationDependencyResolver()
        {
            string pathSettings = AppContext.BaseDirectory;

            Configuration = new ConfigurationBuilder()
                .SetBasePath(pathSettings)
                .AddJsonFile(fileSettings, false)
                .Build();
        }
        /// <summary>
        ///  Singleton: Instancia a primeira vez e reutiliza em todos os lugares
        ///  Transient: Instancia o serviço quando solicitado e a cada nova requisição ele cria novas instancias. ex: 5 dependencias = 5 instancias
        ///  Scope: Instancia o serviço quando solicitado e compartilha a mesma a cada nova requisicao. Quando um outro contexto precisa é criada uma nova instancia e compartilhada dentro do contexto.
        /// </summary>
        /// <param name="services"></param>
        public static void DependencyResolver(IServiceCollection services)
        {
            services.AddSingleton(Configuration);
            services.AddSingleton(CreateAutoMapperConfiguration());
            services.AddScoped<IRepository, Repository>();
        }

        private static IMapper CreateAutoMapperConfiguration() =>
            new MapperConfiguration(configuration =>
            {
                configuration.AddProfile(new MappingProfile()); 
            }).CreateMapper();
    }
}
