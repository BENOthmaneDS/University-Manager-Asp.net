using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationAuth.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult CultureFr()
        {
            Resources.ModelsResources.ResourceAccount.Culture = Resources.MyResource.Culture = new System.Globalization.CultureInfo("fr-FR");
            return RedirectToAction("Index");
        }

        public ActionResult CultureEn()
        {
            Resources.ModelsResources.ResourceAccount.Culture = Resources.MyResource.Culture = new System.Globalization.CultureInfo("en-US");
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}