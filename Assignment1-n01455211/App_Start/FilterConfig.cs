﻿using System.Web;
using System.Web.Mvc;

namespace Assignment1_n01455211
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
