using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4DotNet4.Areas.Guitars.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Guitars/Default/

        public ActionResult Index()
        {
            return View();
        }

    }
}
