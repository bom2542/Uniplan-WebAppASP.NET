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
        public ActionResult CustomerList()
        {
            UniplansEntities db = new UniplansEntities();
            return View(db.AspNetUsers.ToList()); 
        }

    public ActionResult Index()
        {
            UniplansEntities db = new UniplansEntities();
            var UserCount = db.AspNetUsers.Count() - 1;
            ViewBag.UserCount = UserCount;

            var GoalCount = db.Goals.Count();
            ViewBag.GoalCount = GoalCount;

            var PlannerCount = db.Planners.Count();
            ViewBag.PlannerCount = PlannerCount;

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
            using UniplanEntities ue = new UniplanEntities();
            var events = ue.Events.ToList();
            return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}