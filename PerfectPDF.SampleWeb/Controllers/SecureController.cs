using System.Web.Mvc;
using PerfectPdf;

namespace PerfectPDF.SampleWeb.Controllers
{
	[Authorize]
	public class SecureController : Controller
	{
		public ViewResult SecretPage()
		{
			return View();
		}

		public PdfActionResult<SecureController> PrintSecretPage()
		{
			return new PdfActionResult<SecureController>(x => x.SecretPage());
		}
	}
}