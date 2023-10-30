using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrevelTricProject.Models.Classes;

namespace TrevelTricProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.Take(6).ToList();
            return View(values);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var values = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = c.Blogs.ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial3()
        {
            var values = c.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var values = c.Blogs.Take(3).OrderByDescending(x =>x.ID).ToList();
            return PartialView(values);
        }
    }
}