using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        TravelContext context = new TravelContext();
        BlogComment blogComment = new BlogComment();
        public ActionResult Index()
        {
            //var blog = context.Blogs.ToList();
            blogComment.Deger1 = context.Blogs.ToList();
            blogComment.Deger3 = context.Blogs.OrderByDescending(x => x.Id).Take(1).ToList();
            return View(blogComment);
        }

        
        public ActionResult BlogDetail(int id)
        {
            // var blogfind = context.Blogs.Where(x => x.Id == id).ToList();
            blogComment.Deger1 = context.Blogs.Where(x => x.Id == id).ToList();
            blogComment.Deger2 = context.CommentStatements.Where(x => x.BlogId == id).ToList();
            return View(blogComment);
        }

        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Comment(CommentStatement commentStatement)
        {
            context.CommentStatements.Add(commentStatement);
            context.SaveChanges();
            return PartialView();
        }
    }
}