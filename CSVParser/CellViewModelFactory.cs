using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser
{
    public class CellViewModelFactory : ICellViewModelFactory
    {

        private IEnumerable<CellDefinition> _definitions;

        public CellViewModelFactory(ICellDefinitionProvider cellProvider)
        {
            _definitions = cellProvider.Get();
        }

        public BaseCellViewModel Create(ISubscription sub, string name)
        {
            return new BaseCellViewModel();
        }
    }
}
