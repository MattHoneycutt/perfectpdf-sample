namespace PerfectPDF.SampleWeb.Models
{
	public class InvoiceItemViewModel
	{
		public string Description { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal TotalPrice { get; set; }
	}
}