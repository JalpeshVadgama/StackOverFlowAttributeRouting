using System.Text.RegularExpressions;
using System.Web.Mvc;
namespace StackOverFlowRouting.Helpers
{
    public static class TitleHelper
    {
        public static string ClearnUrl(this HtmlHelper htmlHelper, string title)
        {
            string cleanTitle = title.ToLower().Replace(" ", "-"); 
            //Removes invalid character like .,-_ etc
            cleanTitle = Regex.Replace(cleanTitle, @"[^a-zA-Z0-9\/_|+ -]", "");
            return cleanTitle;
        }
    }
}