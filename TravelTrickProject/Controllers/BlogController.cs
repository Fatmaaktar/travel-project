using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrickProject.Models.Classes;

namespace TravelTrickProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogComment by = new BlogComment();
        public ActionResult Index()
        {
            //var blogs = c.Blogs.ToList();
            by.Value1 = c.Blogs.ToList();
            by.Value3 = c.Blogs.Take(8).ToList();
            return View(by);
        }
        public ActionResult BlogDetail(int id=1)
        {

            //var blogfine = c.Blogs.Where(x => x.ID == id).ToList();
            by.Value1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Value2 = c.Comments.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult CommentMake(int id)
        {
            ViewBag.values = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult CommentMake(Comment co)
        {
            c.Comments.Add(co);
            c.SaveChanges();
            return PartialView();
        }
    }
}
