using System.Web.Mvc;
using PerfectPdf;
using PerfectPDF.SampleWeb.Models;

namespace PerfectPDF.SampleWeb.Controllers
{
	public class DashboardController : Controller
	{
		//Normal ASP.NET MVC Action that renders a dashboard...
		public ActionResult Dashboard(DashboardType? type)
		{
			var dashboardModel = GetDashboard(type ?? DashboardType.Sales);

			return View(dashboardModel);
		}

		//Simple wrapper that creates a PDF of the dashboard!
		public ActionResult PrintDashboard(DashboardType type)
		{
			return new PdfActionResult<DashboardController>(c => c.Dashboard(type));
		}

		private DashboardViewModel GetDashboard(DashboardType type)
		{
			return new DashboardViewModel{ Type = type};
		}
	}
}