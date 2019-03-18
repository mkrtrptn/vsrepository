using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vsgitmvcapp.Controllers
{
    public class DemoController : Controller
    {
       // Updated from remotely
       // Update 2
       // upfate from visual studio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult index1()
        {
            return Content("Hello");
        }

        public ActionResult store()
        {
          return RedirectToAction("index1","Demo");
        }

        public ActionResult welcome()
        {
        return Content("welcome Method");
        }

        public ActionResult welcome()
        {
            return Content("Welcome Method");
        }

    }
}
