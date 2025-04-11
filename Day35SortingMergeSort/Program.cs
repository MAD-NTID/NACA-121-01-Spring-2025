// Generate an Unsorted Array of Names
string[] names = ["Yarin", "Skylar", "Amber", "Nai", "Usfer"];

MergeSort<string> ms = new();
names = ms.Sort(names);

Console.Write("Sorted Names [");
for(int i = 0; i < names.Length; i++)
    Console.Write($"{names[i]},");
Console.WriteLine("]");

// // Generate a Random Unsorted Array of Integers
// Random random = new();

// int[] ints = new int[random.Next(100)];

// Console.Write("Unsorted Random Numbers [");
// for(int i = 0; i < ints.Length; i++)
// {
//     ints[i] = random.Next(0, 1000);
//     Console.Write($"{ints[i]},");
// }
// Console.WriteLine("]");

// // Sort it
// MergeSort<int> ms = new();

// ints = ms.Sort(ints);

// Console.Write("Sorted Random Numbers [");
// for(int i = 0; i < ints.Length; i++)
//     Console.Write($"{ints[i]},");
// Console.WriteLine("]");