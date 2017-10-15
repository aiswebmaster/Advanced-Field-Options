using Sitecore.Foundation.FieldOptions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Foundation.FieldOptions.Models.Data;
using Sitecore.Data.Items;
using Sitecore.Collections;

namespace Sitecore.Foundation.FieldOptions
{
    public class FieldRepository : IFieldRepository
    {

        public IEnumerable<IFieldOption> GetFieldsByType(Guid fieldTypeTemplateId)
        {
            var database = Sitecore.Context.ContentDatabase;

            if (database == null)
                return null;

            Item fieldDefinitionFolder = database.GetItem(new Data.ID(FieldOptions.Constants.FieldDefinitionPathId));

            if (fieldDefinitionFolder == null)
            {
                return null;
            }

            ChildList fieldDefinitions = fieldDefinitionFolder.GetChildren();

            if (fieldDefinitions != null && fieldDefinitions.Any())
            {
                var field = fieldDefinitions.FirstOrDefault(f => f.ID.ToGuid().Equals(fieldTypeTemplateId));

                // Return Collection of Field Options
                field.
            }

            using 


            return null;
        }
    }
}