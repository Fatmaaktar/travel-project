using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTrickProject.Models.Classes;

namespace TravelTrickProject.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var informations = c.Admins.FirstOrDefault(x => x.User == ad.User &&
            x.Password == ad.Password);
            if (informations!=null)
            {
                FormsAuthentication.SetAuthCookie(informations.User,false);
                Session["User"] = informations.User.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "LogIn");
        }
    }
}
