using System.Web;
using System.Web.Routing;
using Mvc4DotNet4.Services.Tenant;

namespace Mvc4DotNet4.Services
{
    public interface ITenantService
    {
        void GetTenant();
        void GetTenant(string methodName, RouteData routeData); 
    }

    public class TenantService : ITenantService
    {
        private ITenantSettings _tenantSettings;

        public TenantService(ITenantSettings tenantSettings)
        {
            _tenantSettings = tenantSettings;

        }
        public void GetTenant()
        {
            _tenantSettings.Log(HttpContext.Current.Request.Url.ToString());
        }

        public void GetTenant(string methodName, RouteData routeData)
        {
            _tenantSettings.Log(methodName, routeData);
        }
    }
}