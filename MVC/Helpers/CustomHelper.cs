using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;

namespace MVC
{
    public static class CustomHelper
    {
        public static IHtmlString CreateImage(string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img scr ='{0}' alt ='{1}'>", src, alt));
        }

        public static IHtmlString Img(this System.Web.Mvc.HtmlHelper helper, string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img scr ='{0}' alt ='{1}'>", src, alt));
        }

        public static IHtmlString Alert(this System.Web.Mvc.HtmlHelper helper, string Meassage)
        {
            return new MvcHtmlString(string.Format("<div class=\"alert alert-danger\" role=\"alert\">" + Meassage + "</div>"));
        }

        public static String HelloWorldString(this System.Web.Mvc.HtmlHelper htmlHelper)
           => "<strong>Hello World</strong>";

       

    }
}