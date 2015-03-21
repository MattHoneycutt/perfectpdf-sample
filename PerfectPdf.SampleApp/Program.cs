using System.Diagnostics;
using System.IO;

namespace PerfectPdf.SampleApp
{
	/// <summary>
	/// This app illustrates generating a PDF from a Razor view file outside of ASP.NET using Perfect PDF.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			var converter = new RazorPdfConverter();
			var bytes = converter.ConvertViewToPdf("WelcomeLetter.cshtml");

			var file = Path.Combine(Path.GetTempPath(), "welcome.pdf");
			File.WriteAllBytes(file, bytes);

			//Open up the PDF file for viewing...
			Process.Start(file);
		}
	}
}
