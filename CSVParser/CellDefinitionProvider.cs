using Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser
{
    public class CellDefinitionProvider : ICellDefinitionProvider
    {

        ICollection<CellDefinition> Rows = new List<CellDefinition>();


        public CellDefinitionProvider()
        {

            try
            {
                var csv = File.ReadAllText("sample.csv");                
                foreach (var line in CsvReader.ReadFromText(csv))
                {
                    if (line.IsValid())
                    {
                        Rows.Add(GetRow(line));
                    }
                }
                if (Rows.Count == 0)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                //log
                //throw
            }                         
        }

    
        private CellDefinition GetRow(ICsvLine line)
        {

            var cellDefinition = new CellDefinition
            {
                Key = line[0]
            };

            foreach (var row in line.Headers.Skip(1))
            {                
                if (!cellDefinition.Columns.ContainsKey(row) && !string.IsNullOrEmpty(line[row]))
                {
                    cellDefinition.Columns.Add(row, line[row]);
                }
            }

            return cellDefinition;
        }



        public IEnumerable<CellDefinition> Get()
        {

            throw new NotImplementedException();
        }
    }

    public static class ICSVLineExtension
    {

        public static bool IsValid(this ICsvLine line)
        {
            if (line.Headers.Contains("key") && line.Headers.Count() > 1)
                return true;
               
            return false;
        }
    }
}
