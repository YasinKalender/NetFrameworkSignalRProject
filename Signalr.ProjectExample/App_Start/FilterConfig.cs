﻿using System.Web;
using System.Web.Mvc;

namespace Signalr.ProjectExample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
