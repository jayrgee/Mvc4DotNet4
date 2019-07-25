using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Mvc4DotNet4.Services.Tenant
{
    public interface ITenantConfiguration
    {
        void Log(string message);
        void Log(string methodName, RouteData routeData);
    }

    public class TenantConfiguration : ITenantConfiguration
    {
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