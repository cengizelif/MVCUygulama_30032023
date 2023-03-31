using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MVCUygulama_30032023.Library
{
    public static class HelperClass
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string name="", string text="", string id="",ButonTip typ=ButonTip.button)
        {
            string html =string.Format("<button type='{0}' id='{1}' name='{2}'> {3} </button>",typ,id,name,text);
            return MvcHtmlString.Create(html);
        }
        public static MvcHtmlString Button(this HtmlHelper helper,  string text = "", string id = "", string name = "",string cssclass= "btn", ButonTip typ = ButonTip.button)
        {
            TagBuilder tag = new TagBuilder("button");
            tag.GenerateId(id);
            tag.Attributes.Add(new KeyValuePair<string,string>("type",typ.ToString()));
            tag.Attributes.Add(new KeyValuePair<string, string>("name", name));
            tag.AddCssClass(cssclass);
            
            tag.SetInnerText(text);

            return MvcHtmlString.Create(tag.ToString());
        }

    }

    public enum ButonTip
    {
        button,reset,submit
    }
}