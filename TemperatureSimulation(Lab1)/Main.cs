using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSimulation_Lab1_
{
    class Main : Show
    {
        public Main()
        {
            Console.WriteLine("Enter number: ");
            string inputString = Console.ReadLine();
            int N = 0;
            int.TryParse(inputString, out N);
            showRandomNumber();
            showList(N);
            FileOperations filOp = new FileOperations(listOfTemp);
            //filOp.serializationSaveToFile();
            //filOp.saveToFile();
            //filOp.readFile(6);
            filOp.serializationRead(false);
            Operations Op = new Operations(4);

        }

    }
}
