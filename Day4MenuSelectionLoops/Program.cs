// Show a menu and validate selections
int choice;

//  One way to do it
// do 
// {
//     Console.WriteLine("Select an Options\n" +
//     "1. Option 1\n" +
//     "2. Option 2\n" +
//     "3. Option 3\n" +
//     "4. Exit");

//     Console.Write("Select: ");

//     choice = int.Parse(Console.ReadLine());

//     switch(choice) 
//     {
//         case 1:
//             Console.WriteLine("Option 1 is Selected");
//             break;
//         case 2:
//             Console.WriteLine("Option 2 is Selected");
//             break;
//         case 3:
//             Console.WriteLine("Option 3 is Selected");
//             break;
//         case 4:
//             Console.WriteLine("Option 4 is Selected. Exiting.");
//             break;
//         default:
//             Console.WriteLine("Sorry, Invalid Selection. Try again");
//             break;
//     }
// } while(!(choice >= 1 && choice <= 4));

// Another way to do it
// while(true) 
// {
//     Console.WriteLine("Select an Options\n" +
//         "1. Option 1\n" +
//         "2. Option 2\n" +
//         "3. Option 3\n" +
//         "4. Exit");

//     Console.Write("Select: ");

//     choice = int.Parse(Console.ReadLine());

//     if(choice >= 1 && choice <= 3) 
//     {
//         Console.WriteLine($"Option {choice} is Selected");
//         break;
//     }
//     else if(choice == 4) 
//     {
//         // the reason we have a different if, is for customized message for exiting
//         Console.WriteLine("Option 4 is Selected. Exiting.");
//         // This controls the exiting of the loop
//         break;
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, Invalid Selection. Try again");
//     }
// }

// Another way using while (true), but with switch inside
bool continueOptionSelection = true;
while(continueOptionSelection) 
{
    Console.WriteLine("Select an Options\n" +
        "1. Option 1\n" +
        "2. Option 2\n" +
        "3. Option 3\n" +
        "4. Exit");

    Console.Write("Select: ");

    choice = int.Parse(Console.ReadLine());

    switch(choice) 
    {
        case 1:
            Console.WriteLine("Option 1 is Selected");
            break;
        case 2:
            Console.WriteLine("Option 2 is Selected");
            break;
        case 3:
            Console.WriteLine("Option 3 is Selected");
            break;
        case 4:
            Console.WriteLine("Option 4 is Selected. Exiting.");
            break;
        default:
            Console.WriteLine("Sorry, Invalid Selection. Try again");
            break;
    }

    if(choice >= 1 && choice <= 4)
    {
        continueOptionSelection = false;
    }
}