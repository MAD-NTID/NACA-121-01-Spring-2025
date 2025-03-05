using System.Runtime.CompilerServices;

Console.WriteLine("Welcome to Cars Management App");
Console.WriteLine("==============================");

Cars cars = new();

while(true)
{
    Console.Write("Select an Option (1-5): ");
    string option = Console.ReadLine() ?? "0";

    if(option == "1")
    {
        cars.WriteStream();
        Console.WriteLine("All Cars has been saved");
    }
    else if(option == "2")
    {
        if(cars.StreamReader())
            Console.WriteLine("Read from file successfully");
        else
            Console.WriteLine("Could not find the file");
    }
    else if(option == "3")
    {
        Console.Write("Enter a row to get a car: ");
        int row = int.Parse(Console.ReadLine() ?? "0");

        // Get a car from a specific row
        Console.WriteLine(cars.GetCar(row));
    }
    else if(option == "4")
    {
        Console.WriteLine("Cars Summary");
        Console.WriteLine(cars);
    }
    else if(option == "5")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Option");
    }

    Console.WriteLine();
}

Console.WriteLine("Thank you for using our Cars Management App");