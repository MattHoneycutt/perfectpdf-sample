using System.Web.Mvc;
using PerfectPdf;

namespace PerfectPDF.SampleWeb.Controllers
{
    public class FullPageController : Controller
    {
	    public ViewResult FullPageDemo()
	    {
		    return View();
	    }

	    public ActionResult FullPageDemoPdf()
	    {
		    return new PdfActionResult<FullPageController>(c => c.FullPageDemo())
		    {
				Options =
				{
					Margin = "0"
				}
		    };
	    }
    }
}