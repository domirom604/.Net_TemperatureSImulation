using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSimulation_Lab1_
{
    class TemperatureSimulation: IGenerator
    {
        private List<double?> nTempValues = new List<double?>();
        private double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        private Nullable<double> Random()
        {
            Random randObj = new Random(1);
            Nullable<double> tempValue = null;
            double randomValue = GetRandomNumber(-100.0, 100.0);
            if(randomValue<-80.0) { }
            else
            {
                tempValue = randomValue;
            }

            return tempValue;
        }
        private Nullable<double> generateTemperature()
        {
            return Random();
        }
        private List<double?> generateNTemperature(int N)
        {
            for(int i = 0; i < N; i++)
            {
                nTempValues.Add(Random());
            }
            return nTempValues;
        }
        public List<double?> GetData(int number)
        {
            generateNTemperature(number);
            return nTempValues;
        }

    }
}
