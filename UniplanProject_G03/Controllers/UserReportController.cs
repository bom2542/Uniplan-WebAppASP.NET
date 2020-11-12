using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniplanProject_G03.Controllers
{
    public class UserReportController : Controller
    {
        // GET: UserReport
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string url)
        {
             url = "~/Reports/UserReport.aspx";
             return Redirect(url);
        }
    }
}