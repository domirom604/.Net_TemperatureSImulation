using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSimulation_Lab1_
{
    interface IGenerator
    {
        List<double?> GetData(int number);
    }
}
