using System;
namespace IndainStateAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePathStateCensus = @"C:\GitRepository\IndainStateAnalyzer\StateCensusDAO.cs";
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            int StateCensusrRecords = analyzer.ReadStateCensusData(filePathStateCensus);
            CSVStateCensus census = new CSVStateCensus();
            int censusRecords = census.ReadStateCensusData(filePathStateCensus);
            if (StateCensusrRecords == censusRecords)
                Console.WriteLine("number od records matchs");
        }
    }
}
