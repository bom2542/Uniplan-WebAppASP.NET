using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniplanProject_G03.Controllers
{
    public class SumarizeUserReportController : Controller
    {
        // GET: SumarizeUserReport
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string url)
        {
            url = "~/Reports/SumarizeUserReport.aspx";
            return Redirect(url);
        }
    }
}