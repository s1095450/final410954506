using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final410954506.Controllers
{
    public class DateController : Controller
    {
        // GET: Date
        public ActionResult Index(string number)
        {
            string result = "";
          
          
                result = "星期"+number;
          

            ViewBag.result = result;
            return View();
        }
    }
}