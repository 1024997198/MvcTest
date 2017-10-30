using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcTest.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string UserName, string Password)
        {
            if (UserName == "admin" && Password == "111111")
            {
                FormsAuthentication.RedirectFromLoginPage("admin", false);
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}