using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndainStateAnalyzer
{
    public class CSVStateCensus
    {
        private TextReader reader;
        private object cultureInfo;

        public int ReadStateCensusData(string filePath ,string cultureInfo)
        {
            using (var stream = File.OpenRead(filePath))
            using (var csvReader = new CsvReader(reader, cultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<StateCensusDAO>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data);
                }
                return records.Count() - 1;
            }
        }
    }
}
