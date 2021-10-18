using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TransportTask
{
    public class FilePath
    {
        public string ReceivePath(string nameFile)
        {
            return $@"..\..\{nameFile}";
        }
        
        public int[] ReceiveStocksOrConsumers(string path, string rowName)
        {
            string[] lines = File.ReadAllLines(path);
            string pattern = $@"{rowName}:\s";
            int[] row = {};

            foreach (var line in lines)
            {
                if (Regex.IsMatch(line, pattern))
                {
                    row = Array.ConvertAll(Regex.Replace(line, pattern,String.Empty).Split(' '), int.Parse);
                    break;
                }
            }

            return row;
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