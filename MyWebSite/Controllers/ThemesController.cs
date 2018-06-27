using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    public class ThemesController : Controller
    {
        // GET: Themes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Theme1()
        {
            return PartialView();
        }
    }
}