// // Let's force a NullReferenceException
// string someValue = null;   //  someValue is not initialized with a value

// try 
// {
//     Console.WriteLine($"someValue variable has {someValue.Length} number of characters");
// }
// catch // this is universal, catch 'any' exceptions
// {
//     Console.WriteLine($"Ooops, something wrong happened");
// }
// // catch(NullReferenceException nre)    // this is specific, customizing behavior 
// // {
// //     Console.WriteLine($"Ooops, something wrong happen. The error code is {nre.Message}");
// // }

string[] students = new string[5];

try 
{
    Console.WriteLine($"The student at position 5 is {students[5]}");
}
catch(IndexOutOfRangeException nooe)
{
    Console.WriteLine($"Oops, that index position 5 was not good... {nooe.Message}. Try between 0 and {students.Length - 1}");
}