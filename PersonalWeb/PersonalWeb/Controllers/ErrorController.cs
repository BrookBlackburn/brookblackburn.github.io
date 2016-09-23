using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWeb.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult http404()
        {
            return View();
        }
    }
}