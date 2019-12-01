using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4DotNet4.Areas.ReactUi.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /ReactUi/Default/

        public ActionResult Index()
        {
#if (DEBUG)
            ViewBag.EnableBrowserSync = true;
#endif
            return View();
        }
    }
}
