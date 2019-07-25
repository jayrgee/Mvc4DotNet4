using Mvc4DotNet4.Services.Tenant;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Mvc4DotNet4.Services
{
    public interface ITenantService
    {
        void GetTenant();
        void GetTenant(string methodName, RouteData routeData); 
    }

    public class TenantService : ITenantService
    {
        private ITenantConfiguration _tenantConfiguration;

        public TenantService(ITenantConfiguration tenantConfiguration)
        {
            _tenantConfiguration = tenantConfiguration;

        }
        public void GetTenant()
        {
            _tenantConfiguration.Log(System.Web.HttpContext.Current.Request.Url.ToString());
        }

        public void GetTenant(string methodName, RouteData routeData)
        {
            _tenantConfiguration.Log(methodName, routeData);
        }
    }
}