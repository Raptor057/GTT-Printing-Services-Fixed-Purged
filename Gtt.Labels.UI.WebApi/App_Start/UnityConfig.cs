using Microsoft.Extensions.Configuration;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Gtt.Labels.UI.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            var config = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .Build();

            container.RegisterInstance<IConfiguration>(config);

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}