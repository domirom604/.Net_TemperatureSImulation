using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSimulation_Lab1_
{
    class Show: IGenerator
    {
        TemperatureSimulation tempSim = new TemperatureSimulation();
        protected List<double?> listOfTemp = new List<double?>();
        
        protected void showRandomNumber()
        {
            var randomTempValue =tempSim.Random();
            Console.Write("Random number: " + randomTempValue.ToString());
            Console.WriteLine("");
        }

        protected void showList(int N)
        {
            var list = tempSim.generateNTemperature(N);
            listOfTemp = list;
            double? res = null;
            Console.WriteLine("List of random numbesr: ");
            foreach (var item in list)
            {
                res = item.HasValue ? (double?)Math.Round(item.Value, 2) : null;
                Console.WriteLine(res);
            }
        }
        public List<double?> GetData(int number)
        {
            return listOfTemp;
        }

    }
}
