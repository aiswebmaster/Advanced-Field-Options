using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Foundation.FieldOptions.Controllers
{
    public class FieldOptionController
    {
        public ActionResult OptionsView()
        {
            var repo = new FieldRepository();



            return View(null);
        }
    }
}