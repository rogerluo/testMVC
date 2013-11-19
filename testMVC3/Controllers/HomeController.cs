using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testMVC3.Content
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            ViewBag.username = "roger";
            return View();
        }

        [HttpPost]
        public JsonResult Upload()
        {
            return Json("{[name:luodingjia, age:25, sex:male], [name:rogerluo, age:26, sex:male]}", "text/plain");
        }
    }
}
