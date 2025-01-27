// Validating Empty String
string nameInput;
int ageInput;
double weightInput;

while(true) 
{
    Console.Write("Enter your name: ");

    nameInput = Console.ReadLine();


    if(string.IsNullOrEmpty(nameInput)) // This is best for strings
    // if(nameInput != null && nameInput.Length == 0)
    // if(nameInput == "")
    {
        Console.WriteLine("Invalid Name. Can't be empty");
    }
    else
    {
        Console.WriteLine("Name is Good");
        break;
    }
}

while(true)
{
    Console.Write("Enter your age: ");

    try
    {
        ageInput = int.Parse(Console.ReadLine());

        // If exception is not thrown, the program continues here
        //  ...
        if(ageInput >= 0 && ageInput <= 200)
        {
            Console.WriteLine("Age is good");
            break;
        }
        else 
        {
            Console.WriteLine("Age can't be negative or above 200 years");
        }
    }
    catch(FormatException fe)
    {
        Console.WriteLine($"Invalid Age. The error is {fe.Message}");
    }
}

while(true)
{
    Console.Write("Enter your weight: ");

    try
    {
        weightInput = double.Parse(Console.ReadLine());

        // If exception is not thrown, the program continues here
        //  ...
        if(weightInput >= 0)
        {
            Console.WriteLine("Weight is good");
            break;
        }
        else 
        {
            Console.WriteLine("Weight can't be negative");
        }
    }
    catch(FormatException fe)
    {
        Console.WriteLine($"Invalid Weight. The error is {fe.Message}");
    }
}

Console.WriteLine($"Your name is {nameInput}, and your age is {ageInput} and you weight {weightInput:F2}lbs.");