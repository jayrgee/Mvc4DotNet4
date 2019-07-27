using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Configuration;

namespace Mvc4DotNet4.Services.Tenant
{
    public interface ITenantSettings
    {
        string DefaultTenant { get; set; }
        KeyValueConfigurationCollection TenantPorts { get; set; }

        void Log(string message);
        void Log(string methodName, RouteData routeData);
    }

    public class TenantSettings : ConfigurationSection, ITenantSettings
    {
        public const string SectionName = "tenantSettings";
        private const string DefaultTenantProperty = "defaultTenant";
        private const string TenantPortsProperty = "tenantPorts";

        //private static TenantSettings settings = ConfigurationManager.GetSection(SectionName) as TenantSettings;

        public TenantSettings()
        {
            base[TenantPortsProperty] = new KeyValueConfigurationCollection();
        }

        //public static TenantSettings Settings
        //{
        //    get { return settings; }
        //}

        [ConfigurationProperty(DefaultTenantProperty, IsRequired = true)]
        public string DefaultTenant
        {
            get { return (string)this[DefaultTenantProperty];  }
            set { this[DefaultTenantProperty] = value; }
        }

        [ConfigurationProperty(TenantPortsProperty)]
        public KeyValueConfigurationCollection TenantPorts
        {
            get { return ((KeyValueConfigurationCollection)base[TenantPortsProperty]); }
            set { this[TenantPortsProperty] = value; }
        }

        public void Log(string message)
        {
            Debug.WriteLine(message);
        }

        public void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = String.Format("{0} controller:{1} action:{2}", methodName, controllerName, actionName);
            Debug.WriteLine(message, "Action Filter Log");
        }

    }

}