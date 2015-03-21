using System;
using System.Collections.Generic;

namespace PerfectPDF.SampleWeb.Models
{
	internal class FakeContext
	{
		public IList<Invoice> Invoices { get; set; }

		public FakeContext()
		{
			Invoices = new List<Invoice>();
			Invoices.Add(new Invoice
			{
				InvoiceId = new Guid("68B5B8EB-A03D-41D5-B6C5-872C0E3D4CA0"),
				InvoiceNumber = "JD-2014-65",
				PurchaseDate = DateTime.Today.AddDays(-7),
				Customer = new Customer
				{
					FullName = "John Doe",
					Street = "123 Main Street",
					City = "Paradise",
					State = "SC",
					Zip = "12345"
				},
				Items = new List<InvoiceItem>()
				{
					new InvoiceItem { Description = "Keyboard", Quantity = 1, UnitPrice = 59.99m },
					new InvoiceItem { Description = "8 GB DIMM", Quantity = 2, UnitPrice = 24.99m },
					new InvoiceItem { Description = "24\" Monitor", Quantity = 3, UnitPrice = 199.99m },
					new InvoiceItem { Description = "Mouse", Quantity = 1, UnitPrice = 39.99m },
				}
			});
		}
	}
}