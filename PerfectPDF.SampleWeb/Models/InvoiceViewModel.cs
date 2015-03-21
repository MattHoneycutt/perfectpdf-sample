using System;
using System.Linq;

namespace PerfectPDF.SampleWeb.Models
{
	public class InvoiceViewModel
	{
		public InvoiceViewModel(Invoice invoice)
		{
			InvoiceId = invoice.InvoiceId;
			CustomerName = invoice.Customer.FullName;
			CustomerStreet = invoice.Customer.Street;
			CustomerCity = invoice.Customer.City;
			CustomerState = invoice.Customer.State;
			CustomerZip = invoice.Customer.Zip;
			InvoiceNumber = invoice.InvoiceNumber;
			PurchaseDate = invoice.PurchaseDate;
			Items = invoice.Items.Select(i => new InvoiceItemViewModel
			{
				Description = i.Description,
				Quantity = i.Quantity,
				UnitPrice = i.UnitPrice,
				TotalPrice = i.TotalPrice
			}).ToArray();
			GrandTotal = invoice.GrandTotal;
		}

		public Guid InvoiceId { get; set; }
		public string CustomerName { get; set; }
		public DateTime PurchaseDate { get; set; }
		public decimal GrandTotal { get; set; }
		public InvoiceItemViewModel[] Items { get; set; }
		public string InvoiceNumber { get; set; }
		public string CustomerStreet { get; set; }
		public string CustomerCity { get; set; }
		public string CustomerState { get; set; }
		public string CustomerZip { get; set; }
	}
}