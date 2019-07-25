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

        public MyActionFilter(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _tenantService.GetTenant("OnActionExecuting", filterContext.RouteData);
            _tenantService.GetTenant();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            _tenantService.GetTenant("OnActionExecuted", filterContext.RouteData);
        }
    }
}