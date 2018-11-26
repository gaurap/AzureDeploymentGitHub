using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureDeploymentSample1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page from GitHub using local Git Deployment.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page from GitHub using local Git Deployment.";

            return View();
        }
    }
}