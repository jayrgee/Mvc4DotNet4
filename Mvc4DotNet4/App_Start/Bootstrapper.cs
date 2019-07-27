using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

using Mvc4DotNet4.Services;
using Mvc4DotNet4.Services.Tenant;
using System.Configuration;

namespace Mvc4DotNet4
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ILookupService, LookupService>();
            container.RegisterType<ITenantService, TenantService>();
            container.RegisterType<IMyLogger, MyLogger>();

            container.RegisterInstance((ITenantSettings)ConfigurationManager.GetSection(TenantSettings.SectionName));
        }
    }
}