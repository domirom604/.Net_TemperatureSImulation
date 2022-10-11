using TemperatureSimulation_Lab1_;



Console.WriteLine("Enter number: ");
string inputString = Console.ReadLine();
int N=0;
int.TryParse(inputString,out N);
Show show = new Show();
show.showRandomNumber();
show.showList(N);
FileOperations filOp= new FileOperations(show.listOfTemp);
//filOp.serializationSaveToFile();
//filOp.saveToFile();
//filOp.readFile(6);
filOp.serializationRead(false);

