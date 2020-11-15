using Microsoft.Owin.Security;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using UniplanProject_G03.Models;

namespace UniplanProject_G03.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult CustomerList()
        {
            //UniplansEntities db = new UniplansEntities();
 
            return View(db.Users.ToList()); 
        }

    public ActionResult Index()
        {
    
            var UserCount = db.Users.Count() - 1;
            ViewBag.UserCount = UserCount;

            var GoalCount = db.Goals.Count();
            ViewBag.GoalCount = GoalCount;

            var PlannerCount = db.Planners.Count();
            ViewBag.PlannerCount = PlannerCount;

            ViewBag.BlogList = db.Blogs.Take(4).ToList();

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

        public JsonResult GetEvents()
        {
            var events = db.Events.ToList();
            return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}