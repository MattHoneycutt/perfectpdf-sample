﻿using System.Web;
using System.Web.Mvc;

namespace PerfectPDF.SampleWeb
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
