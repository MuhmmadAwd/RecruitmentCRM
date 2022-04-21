using GlobalDev.Dal;
using GlobalDev.Bal;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace GlobalDev
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<Business>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}