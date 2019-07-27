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
        private IMyLogger _myLogger;

        public TenantService(ITenantSettings tenantSettings, IMyLogger myLogger)
        {
            _tenantSettings = tenantSettings;
            _myLogger = myLogger;

        }
        public void GetTenant()
        {
            _myLogger.Log(HttpContext.Current.Request.Url.ToString());
        }

        public void GetTenant(string methodName, RouteData routeData)
        {
            _myLogger.Log(methodName, routeData);
        }
    }
}