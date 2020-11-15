using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniplanProject_G03.Models;

namespace UniplanProject_G03.Controllers
{
    public class ReportController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Report
        public ActionResult Index()
        {

            ViewBag.SumUserAcc = db.Users.ToList();

            return View();
        }


        public ActionResult ReportPlanner()
        {

            ViewBag.SumPlan = db.Planners.ToList();

            return View();
        }


        public ActionResult ReportBlog()
        {

            ViewBag.SumBlog = db.Blogs.ToList();

            return View();
        }


        public ActionResult ReportGoal()
        {

            ViewBag.SumGoal = db.Goals.ToList();
            ViewBag.PercentGroup = db.Database.SqlQuery<ReportViewModels>("SELECT [Percent], COUNT(UserName) AS Username FROM Goals GROUP BY Goals.[Percent] ORDER BY [Percent] ASC").ToList();

            return View();
        }
    }
}