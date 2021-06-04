using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        /// Resolve as dependencias. Podem ser singleton, scope, ou transient.
        //  SINGLETON: instancia o serviço quando é solicitado pela primeira vez e reutiliza a instancia em todos os lugares
        //  TRANSIENT: instancia o serviço quando é solicitado e a cada requisição nova ou ate na mesma requisição ele cria uma novas instancias ex: 5 dependencias serão 5 instancias novas
        //  SCOPED: instancia o serviço quando é solicitado e a cada requisição ele utiliza a mesma instancia para as demais. A dependencia é compartilhada para instancias do mesmo contexto. em um segundo contexto outro objeto sera criado e compartilhado dentro do contexto.
        /// </summary>
        /// <param name="services"></param>
        public static void DependencyResolver(IServiceCollection services)
        {
            services.AddSingleton(Configuration);
            services.AddScoped<IRepository, Repository>();
        }
    }
}
