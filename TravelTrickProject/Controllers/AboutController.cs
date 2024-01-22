using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrickProject.Controllers;
using TravelTrickProject.Models.Classes;

namespace TravelTrickProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Abouts.ToList();
            return View(values);
        }
    }
}