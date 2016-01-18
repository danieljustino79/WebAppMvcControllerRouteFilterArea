using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMvcControllerRouteFilterArea.Areas.Blog.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult AddPost()
        {
            return View();
        }

        public ActionResult EditPost()
        {
            return View();
        }
    }
}
