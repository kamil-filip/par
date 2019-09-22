using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser
{
    public class CellDefinition
    {
        public string Key { get; set; }

        public Dictionary<string, string> Columns { get; set; } = new Dictionary<string, string>();
    }
}

