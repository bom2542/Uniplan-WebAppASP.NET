using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniplanProject_G03.Models;
using Microsoft.Reporting.WebForms;

namespace UniplanProject_G03.Reports
{
    public partial class SumarizeGoalReport : System.Web.UI.Page
    {
        private UniplansEntities _entities = new UniplansEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.ReportPath = "ReportSources/SummarizeGoalReport.rdlc";
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", _entities.Goals.AsQueryable()));
                ReportViewer1.DataBind();
                ReportViewer1.LocalReport.Refresh();
            }
        }
    }
}