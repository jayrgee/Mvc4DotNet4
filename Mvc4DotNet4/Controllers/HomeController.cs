using System.Web.Mvc;
using Mvc4DotNet4.Services;

namespace Mvc4DotNet4.Controllers
{
    public class HomeController : Controller
    {
        private ILookupService _lookupService;

        public HomeController(ILookupService lookupService)
        {
            _lookupService = lookupService;
        }

        public ActionResult Index()
        {
            _lookupService.LookupValue();

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
