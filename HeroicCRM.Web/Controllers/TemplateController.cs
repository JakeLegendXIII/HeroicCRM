using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeroicCRM.Web.Controllers
{
    public class TemplateController : HeroicCRMControllerBase
    {
        // GET: Template
        public PartialViewResult Render(string feature, string name)
        {
            return PartialView(string.Format("~/js/app/{0}/templates/{1}", feature, name));
        }
    }
}