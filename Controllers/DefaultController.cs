using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var degerler = context.Blogs.OrderByDescending(x=>x.Id).Take(4).ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial()
        {
            var degerler = context.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var deger = context.Blogs.Where(x => x.Id == 6).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial3()
        {
            var deger = context.Blogs.Take(10).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var deger = context.Blogs.Take(3).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial5()
        {
            var deger = context.Blogs.Take(3).OrderByDescending(x=>x.Id).ToList();
            return PartialView(deger);
        }
    }
}