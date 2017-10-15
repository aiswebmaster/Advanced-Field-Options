using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Foundation.FieldOptions.Models.Data
{

    public interface IFieldOption
    {
        string Title { get; set; }
        Guid FieldType { get; set; }
        string ParameterName { get; set; }
        bool IsRequired { get; set; }
    }
}