using Mvc4DotNet4.Filters;
using Mvc4DotNet4.Services;
using System.Web;
using System.Web.Mvc;

namespace Mvc4DotNet4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyActionFilter(DependencyResolver.Current.GetService<TenantService>()));
        }
    }
}