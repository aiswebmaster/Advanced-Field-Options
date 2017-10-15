using Sitecore.Foundation.FieldOptions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Foundation.FieldOptions.Models.Data;
using Sitecore.Data.Items;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch.Linq;

namespace Sitecore.Foundation.FieldOptions
{
    public class FieldRepository : IFieldRepository
    {

        public IEnumerable<IFieldOption> GetFieldsByType(Guid fieldTypeTemplateId)
        {
            var database = Sitecore.Context.ContentDatabase;
            SearchResults<SearchResultItem> results = null;

            if (database == null)
                return null;

            Item fieldTemplateItem = database.GetItem(new Data.ID(fieldTypeTemplateId));

            if (fieldTemplateItem == null)
            {
                return null;
            }

            using (var context = Sitecore.ContentSearch.ContentSearchManager.GetIndex("sitecore_core_index").CreateSearchContext())
            {
                var query = context.GetQueryable<SearchResultItem>();

                query.Where(i => i.Paths.Contains(fieldTemplateItem.ID));

                query.Filter(x => x.TemplateId.ToGuid() == Constants.FieldOptionTemplateId);

                results = query.GetResults<SearchResultItem>();
            }

            if (results != null && results.Any())
            {
                //return results.Where(i => i != null && i.Document != null).Select(i => i.)
            }



            return null;
        }
    }
}