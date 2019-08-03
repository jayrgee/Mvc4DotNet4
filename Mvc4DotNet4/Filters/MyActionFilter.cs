using Mvc4DotNet4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc4DotNet4.Filters
{
    public class MyActionFilter : ActionFilterAttribute
    {
        private ITenantService _tenantService;
        private IMyLogger _myLogger;

        public MyActionFilter(ITenantService tenantService, IMyLogger myLogger)
        {
            _tenantService = tenantService;
            _myLogger = myLogger;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _myLogger.Log("OnActionExecuting", filterContext.RouteData);
            _tenantService.GetTenant();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            _myLogger.Log("OnActionExecuted", filterContext.RouteData);
        }
    }
}