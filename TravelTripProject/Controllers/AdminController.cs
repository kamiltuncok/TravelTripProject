using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Controllers;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        TravelContext context = new TravelContext();

        [Authorize]
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Add(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult GetBlogById(int id)
        {
            var blog = context.Blogs.Find(id);
            return View("GetBlogById", blog);
        }

        [Authorize]
        public ActionResult Update(Blog blog)
        {
            context.Entry(blog).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult CommentList()
        {
            var comments = context.CommentStatements.ToList();
            return View(comments);
        }

        [Authorize]
        public ActionResult DeleteComment(int id)
        {
            var comment = context.CommentStatements.Find(id);
            context.CommentStatements.Remove(comment);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }

        [Authorize]
        public ActionResult GetCommentById(int id)
        {
            var comment = context.CommentStatements.Find(id);
            return View("GetCommentById", comment);
        }

        [Authorize]
        public ActionResult UpdateComment(CommentStatement commentStatement)
        {
            context.Entry(commentStatement).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}