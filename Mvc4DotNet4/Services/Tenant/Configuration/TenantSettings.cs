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
//            base[TenantPortsProperty] = new TenantPorts();
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
//      public TenantPort TenantPorts
        public KeyValueConfigurationCollection TenantPorts
        {
//          get { return ((TenantPort)base[TenantPortsProperty]); }
            get { return ((KeyValueConfigurationCollection)base[TenantPortsProperty]); }
            set { this[TenantPortsProperty] = value; }
        }
    }

    public class TenantPorts : KeyValueConfigurationCollection
    {
        public TenantPorts()
        {

        }

    }

    public class TenantPort : KeyValueConfigurationElement
    {
        public TenantPort(string key, string value) : base(key, value)
        {
        }

        [ConfigurationProperty("key", Options = ConfigurationPropertyOptions.IsKey, DefaultValue = "")]
        public new string Key
        {
            get { return (string)this["key"]; }
        }

        [ConfigurationProperty("value", DefaultValue = "")]
        public new string Value
        {
            get { return (string)this["value"]; }
            set { this["value"] = value; }
        }
    }
}