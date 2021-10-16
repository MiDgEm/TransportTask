using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TransportTask
{
    public class FilePath
    {
        public string ReceivePath(string nameFile)
        {
            return $@"C:\Users\Neste\RiderProjects\TransportTask\TransportTask\{nameFile}";
        }
        
        public List<List<int>> ReceiveStocksOrConsumers(string path)
        {
            string[] lines = File.ReadAllLines(path);
            List<List<int>> stocksOrConsumersFromFile = new List<List<int>>();
            
            foreach (var line in lines)
            {
                string[] _string = line.Split(' ');
                int[] numbers = Array.ConvertAll(_string, int.Parse);
                stocksOrConsumersFromFile.Add(numbers.ToList());
            }
            
            return stocksOrConsumersFromFile;
        }

        public List<List<int>> ReceiveMartixTariff(string path)
        {
            string[] lines= File.ReadAllLines(path);
            List<List<int>> matrixTariff = new List<List<int>>();

            foreach (var line in lines)
            {
                string[] _string = line.Split(' ');
                int[] numbers = Array.ConvertAll(_string, int.Parse);
                matrixTariff.Add(numbers.ToList());
            }

            return matrixTariff;
        }
    }
}