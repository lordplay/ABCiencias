using ABCiencias.Entity;
using ABCiencias.Models.Servicos.Eventos;
using ABCiencias.Models.Servicos.Users;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Back_Mobile
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
            container.RegisterType<IMobileEventoService, MobileEventoService>();
            container.RegisterType<IUserService, UserService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}