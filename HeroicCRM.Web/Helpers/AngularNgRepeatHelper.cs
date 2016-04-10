using HtmlTags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeroicCRM.Web.Helpers
{
    public class AngularNgRepeatHelper<TModel> : AngularModelHelper<TModel>, IDisposable
    {
        public AngularNgRepeatHelper(HtmlHelper helper, 
            string variableName, string propertyExpression) : base(helper, variableName)
        {
            var div = new HtmlTag("div");
            div.Attr("ng-repeat",
                string.Format("{0} in {1}", variableName, propertyExpression));
            div.NoClosingTag();

            Helper.ViewContext.Writer.Write(div.ToString());
        }

        void IDisposable.Dispose()
        {
            Helper.ViewContext.Writer.Write("</div>");
        }
    }
}