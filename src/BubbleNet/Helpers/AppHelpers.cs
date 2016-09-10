using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BubbleNet.Helpers
{
    public static class HtmlHelpers
    {
        public static IHtmlString CommunictionStatus(this HtmlHelper helper, string status)
        {
            var color = string.Empty;
            if (status == "Good")
                color = "green";
            if(status =="Bad")
                color = "red";
            if(status == "Medium")
                color = "brown";
            return new HtmlString("<div style='color:  "  +  color + ";'>" + status + "</div>");
        }
    }
}