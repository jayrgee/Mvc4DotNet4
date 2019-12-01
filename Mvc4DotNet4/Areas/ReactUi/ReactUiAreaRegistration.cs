using System.Web.Mvc;

namespace Mvc4DotNet4.Areas.ReactUi
{
    public class ReactUiAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ReactUi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ReactUi_default",
                "ReactUi/{controller}/{action}/{id}",
                new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
