using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSimulation_Lab1_
{
    public class Operations: FileOperations
    {
        IEnumerable<string> strings =null;
        private List<double?> nTempValues = new List<double?>();

        public Operations(int numberOfProbes): base(null)
        {
            strings = readFile(numberOfProbes);
            nTempValues = strings.Select(s => Double.TryParse(s, out double n) ? n : (double?)null).ToList();
            Console.WriteLine("Avg: " + averageCalcualtion(nTempValues).ToString());
            Console.WriteLine("Std: " + standardDeviationCalculation(nTempValues).ToString());
        }
        public double? averageCalcualtion(List<double?> list)
        {       
            double? avg = 0;
            avg=list.Average();
            return avg;
           
        }
        private double? standardDeviationCalculation(List<double?> list)
        {
            double? standardDeviation = 0;

            if (list.Any())
            {
                double? avg = list.Average();
                double? sum = 0;
                int count = 0;
                foreach(var v in list)
                {
                    if (v != null)
                    {
                        sum += (Math.Pow((double)v - (double)avg, 2));
                        count++;
                    }
                   
                }
                    
                standardDeviation = Math.Sqrt( ((double)sum) / (count) );
            }

            return standardDeviation;
        }
        private void sortNumber(bool saveToFile)
        {

        }
        private void delateInterval(bool saveToFile)
        {

        }


    }
}
