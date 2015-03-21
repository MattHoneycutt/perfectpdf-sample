using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfectPDF.SampleWeb.Models
{
	public class Invoice
	{
		public Guid InvoiceId { get; set; }
		public Customer Customer { get; set; }
		public DateTime PurchaseDate { get; set; }
		public IList<InvoiceItem> Items { get; set; }

		public decimal GrandTotal
		{
			get { return Items.Sum(i => i.TotalPrice); }
		}

		public string InvoiceNumber { get; set; }
	}
}