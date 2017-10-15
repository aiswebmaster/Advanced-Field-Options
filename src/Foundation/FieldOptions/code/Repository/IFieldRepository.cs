using Sitecore.Foundation.FieldOptions.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Foundation.FieldOptions.Repository
{
    public interface IFieldRepository
    {
        IEnumerable<IFieldOption> GetFieldsByType(Guid fieldTypeTemplateId);
    }
}
