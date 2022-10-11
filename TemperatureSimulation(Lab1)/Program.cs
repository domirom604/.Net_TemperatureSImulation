
using TemperatureSimulation_Lab1_;

TemperatureSimulation tempSim = new TemperatureSimulation();
//Console.WriteLine(tempSim.generateTemperature());

Console.WriteLine("Enter number: ");
string inputString = Console.ReadLine();
int N=0;
int.TryParse(inputString,out N);
var list = tempSim.generateNTemperature(N);
double? res =null;
foreach(var item in list)
{
    res = item.HasValue ? (double?)Math.Round(item.Value,2) : null;
    //Console.WriteLine(res);
}
FileOperations filOp= new FileOperations(list);
//filOp.serializationSaveToFile();
//filOp.saveToFile();
//filOp.readFile(6);
filOp.serializationRead(false);

