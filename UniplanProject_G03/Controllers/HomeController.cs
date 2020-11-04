using CrystalDecisions.CrystalReports.Engine;
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

        public ActionResult exportReport()
        {
            UniplansEntities db = new UniplansEntities();
            ReportDocument rd = new ReportDocument();
            //return View(db.AspNetUsers.ToList());
            rd.Load(Path.Combine(Server.MapPath("~/Report/MemberListReport.rpt")));
            //rd.SetDataSource(db.AspNetUsers.ToList());
            rd.SetDataSource(db.AspNetUsers.Select(p => new
            {
                name = p.Name,
                nick = p.Nick,
                year = p.Year,
                university = p.University,
                institute = p.Institute,
                branch = p.Branch
            }).ToList());
            
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();

            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);
            return File(stream, "application/pdf", "MemberReport.pdf");

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