using System;
using System.Linq;
using System.Web.Mvc;
using PerfectPdf;
using PerfectPDF.SampleWeb.Models;

namespace PerfectPDF.SampleWeb.Controllers
{
	public class InvoiceController : Controller
	{
		private readonly FakeContext _context = new FakeContext();

		public ActionResult Invoice(Guid id)
		{
			var invoice = _context.Invoices.Single(i => i.InvoiceId == id);

			var model = new InvoiceViewModel(invoice);

			return View(model);
		}

		public ActionResult PrintInvoice(Guid id)
		{
			var result = new PdfActionResult<InvoiceController>(c => c.Invoice(id));
			return result;
		}
	}
}