using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApplication
{
    public class CustomViewEngine : RazorViewEngine
    {
        public CustomViewEngine(){
            ViewLocationFormats = new[]
            {
                "~/Areas/{1}/Views/{0}.cshtml",
                "~/Areas/Shared/Views/{0}.cshtml"
            };
            PartialViewLocationFormats = ViewLocationFormats;
            MasterLocationFormats = ViewLocationFormats;
        }
    }
}