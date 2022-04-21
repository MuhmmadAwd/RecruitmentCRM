using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using recruitmentCRM.Bal;
using Unity;
using Unity.Mvc5;

namespace recruitmentCRM.Web.App_Start
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<StudentService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

    }
}