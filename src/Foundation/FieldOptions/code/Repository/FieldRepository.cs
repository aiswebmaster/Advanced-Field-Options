using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Foundation.FieldOptions
{
    public class FieldRepository
    {
        public IEnumerable<> GetFieldsByType(Guid fieldType)
        {
            using (var context = Sitecore.ContentSearch.ContentSearchManager.GetIndex("sitecore_web_index").CreateSearchContext())
            {

            }
        }
    }
}