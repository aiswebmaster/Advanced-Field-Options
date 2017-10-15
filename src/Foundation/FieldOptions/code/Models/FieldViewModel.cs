using Sitecore.Foundation.FieldOptions.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Foundation.FieldOptions.Models
{
    public class FieldViewModel
    {
        public IEnumerable<IFieldOption> FieldOptions { get; set; }

    }
}