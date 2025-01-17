// Console.Write("Enter your name: ");

// Console will stop here and wait for user input
// string name = Console.ReadLine();

// Console.Write("Enter your age: ");
// int age = int.Parse(Console.ReadLine());
// string ageString = age.ToString();  // this is explicit conversion

// because of interpolation {age} is implicitly converted to string
// Console.WriteLine($"Your name is {name} and you are {age} years old");

// You can initialize multiple variables of the same type in one STATEMENT
// int a = 1, 
//     b = 2, 
//     c = 3, 
//     d = 4;

// int a2 = 1;
// int b2 = 2;
// int c2 = 3;
// int d2 = 4;

// Let's compare prefix and postfix
// int value = 5;

// // what is the value now before I prefix increment
// // Console.WriteLine(++value);

// // What is the value now after I postfix increment
// Console.WriteLine(value++);

// // What's the value after?
// Console.WriteLine(value);

bool cold = false;

if(cold) 
    // if only one statement after if, don't need curly brackets
    Console.WriteLine("Wear a coat");
else 
{
    Console.WriteLine("Wear shorts");
}