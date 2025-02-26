// This will create a Printer instance of 5 elements in the array
Printer<string> stringPrinter = new Printer<string>(6);

stringPrinter.Add("Yarin");
stringPrinter.Add("Skylar");
stringPrinter.Add("Amber");
stringPrinter.Add("Nailea");
stringPrinter.Add("Usfer");
stringPrinter.Add("Michael");

for(int i = 0; i < stringPrinter.Size; i++)
{
    Console.WriteLine($"Printing {i + 1}: {stringPrinter.Print()}");
}

Console.WriteLine();
Console.WriteLine("Finished Printing");