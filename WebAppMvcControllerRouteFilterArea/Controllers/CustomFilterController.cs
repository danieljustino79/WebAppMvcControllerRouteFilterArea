using System.Collections.Generic;
using System.Web.Mvc;

using WebAppMvcControllerRouteFilterArea.Filter;

namespace WebAppMvcControllerRouteFilterArea.Controllers
{
    public class CustomFilterController : Controller
    {
        public static List<string> log = new List<string>();

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public void Restrict()
        {

        }

        [OutputCache(Duration = 10)]
        public string DateTimeHourMinuteSecond()
        {
            return System.DateTime.Now.ToString("T");
        }

        [MyCustomFilterByAction]
        public ActionResult Custom()
        {
            ViewBag.log = log;
            return View();
        }

        //public static List<string> log = new List<string>();

        //[MyCustomFilterByAction]
        //public ActionResult Index()
        //{
        //    ViewBag.log = log;
        //    return View();
        //}

        //[MyCustomFilterByAction]
        //public string Index2()
        //{
        //    string text = "";
        //    foreach (var item in log)
        //    {
        //        text += item+"<br>";
        //    }
        //    return "Text:<br>" + text;
        //}

    }
}
