using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser
{
    public class BaseCellViewModel { }
    public interface ISubscription { }

    public interface ICellViewModelFactory
    {
        BaseCellViewModel Create(ISubscription sub, string name);
    }
}
