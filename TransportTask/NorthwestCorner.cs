using System;
using System.Collections.Generic;

namespace TransportTask
{
    public class NorthwestCorner
    {
        public int[][] FindNorthwestCorner(int[] stocks, int[] consumers)
        {
            int[][] shipment = new int[stocks.Length][];
            
            for (int i = 0; i < stocks.Length; i++)
                shipment[i] = new int[consumers.Length];

            for (int i = 0; i < stocks.Length; i++)
            {
                for (int j = 0; j < consumers.Length; j++)
                {
                    if( consumers[j] == 0 ) continue;
            
                    int minvValue = Math.Min( stocks[i], consumers[j] );
                    shipment[i][j] = minvValue;
                    stocks[i] -= minvValue;
                    consumers[j] -= minvValue;
            
                    if( stocks[i] == 0 ) break;
                }
            }
            
            return shipment;
        }
        public string CountCostDelivery(int[] stocks, int[] consumers, int[][] array, List<List<int>> matrixTariff)
        {
            int amountTariff = 0;
            
            for (int i = 0; i < stocks.Length; i++)
            {
                for (int j = 0; j < consumers.Length; j++)
                {
                    if (array[i][j] > 0)
                    {
                        amountTariff += array[i][j] * matrixTariff[i][j];
                    }
                }
            }
            
            return amountTariff.ToString();
        }
    }
}