using System;
using System.Collections.Generic;
using System.IO;

namespace TransportTask
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                FilePath filePath = new FilePath();
                int[] stocks = filePath.ReceiveStocksOrConsumers(filePath.ReceivePath("StocksOrConsumers.txt"))[0].ToArray();
                int[] consumers = filePath.ReceiveStocksOrConsumers(filePath.ReceivePath("StocksOrConsumers.txt"))[1].ToArray();
                List<List<int>> matrix = filePath.ReceiveMartixTariff(filePath.ReceivePath("MatrixTariff.txt"));

                NorthwestCorner northwestCorner = new NorthwestCorner();
                int[][] array = northwestCorner.FindNorthwestCorner(stocks,consumers);
                string costDelivery = northwestCorner.CountCostDelivery(stocks, consumers, array, matrix);
                
                const string result = "Result.txt";
                File.WriteAllText(filePath.ReceivePath(result), costDelivery);
                
                Console.WriteLine("The program is completed. Check the file " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        } 
    }
}