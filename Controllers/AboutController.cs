using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var degerler = context.Abouts.ToList();
            return View(degerler);
        }
    }
}