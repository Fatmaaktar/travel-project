using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrickProject.Models.Classes;

namespace TravelTrickProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogDelete(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogShow(int id=1)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogShow",bl);
        }
        public ActionResult BlogUpdate(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Explanation = b.Explanation;
            blg.Title = b.Title;
            blg.BlogImage = b.BlogImage;
            blg.History = b.History;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var comments = c.Comments.ToList();
            return View(comments);
        }
        public ActionResult CommentDelete(int id)
        {
            var b = c.Comments.Find(id);
            c.Comments.Remove(b);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult CommentCome(int id)
        {
            var cm = c.Comments.Find(id);
            return View("CommentCome", cm);
        }
        public ActionResult CommentUpdate(Comment y)
        {
            var com = c.Comments.Find(y.ID);
            com.UserName = y.UserName;
            com.Mail = y.Mail;
            com.Comment2 = y.Comment2;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}
