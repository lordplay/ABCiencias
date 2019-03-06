using ABCiencias.Entity;
using ABCiencias.Models.Servicos.Fornecedores;
using ABCiencias.Models.Servicos.Shortener;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace ABCiencias
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IABCienciasContext, ABCienciasContext>();
            container.RegisterType<IURLShortenerContext, URLShortenerContext>();

            container.RegisterType<IFornecedorService, FornecedorService>();

            container.RegisterType<IShortenerService, ShortenerService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}