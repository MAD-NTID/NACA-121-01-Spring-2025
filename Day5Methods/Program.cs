Console.Write("Select which method to call\n1. SayHello()\n2. SayHelloWithName()\n3. GetANumber\n4. GetSomeString()\n5. SayHelloWithName() and Age\nSelect: ");

string input = Console.ReadLine();

switch(input) 
{
    case "1":
        SayHello();
        break;

    case "2":
        // This case will prompt for the user's name and print hello with name
        Console.Write("Enter your name: ");
        string nameInput = Console.ReadLine();

        SayHelloWithName(nameInput);
        break;

    case "3":
        Console.WriteLine($"The number is {GetANumber()}");
        break;

    case "4":
        Console.WriteLine($"The string is {GetSomeString()}");
        break;

    case "5":
        // This case will prompt for the user's name and print hello with name
        Console.Write("Enter your name: ");
        nameInput = Console.ReadLine();

        Console.Write("Enter Age (put zero if you don't want to provide): ");
        int age = int.Parse(Console.ReadLine());

        if(age != 0)
            SayHelloWithName(nameInput, age);
        else
            SayHelloWithName(nameInput);
        break;

    default:
        Console.WriteLine("Not a valid option");
        break;
}


//  Because it's void, you don't have to say "return"
static void SayHello() 
{
    Console.WriteLine("Hello World");
}

// This method has parameters with local variable names
static void SayHelloWithName(string name, int age = 0) // this is a "signature"
{
    // Local because name can only be used inside this method (scope)
    Console.WriteLine($"Hello World, your name is {name}");

    // Age is optional because it has an assigned value in parameters
    // You are not required to pass any value to age if you don't need it
    //  We can do stuff like
    if(age != 0)
        Console.WriteLine($"Your age is {age}");
}

// Because it's int, you must return an int
static int GetANumber() 
{
    return 0;
}

static string GetSomeString() 
{
    return "Well, hello there!";
}


//  This is Pascal Naming Convetion (we will use this one for methods)
//  GetARandomNumber

//  This is Camel Case Naming Convention (we will use this one for variables)
//  getARandomNumber