using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser
{
    public interface ICellDefinitionProvider
    {
        IEnumerable<CellDefinition> Get();
    }
}
