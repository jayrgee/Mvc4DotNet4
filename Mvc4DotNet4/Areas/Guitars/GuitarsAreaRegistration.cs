using System.Web.Mvc;

namespace Mvc4DotNet4.Areas.Guitars
{
    public class GuitarsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Guitars";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Guitars_default",
                "Guitars/{controller}/{action}/{id}",
                new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
