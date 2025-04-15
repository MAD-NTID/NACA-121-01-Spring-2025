Random random = new();

int[] ints = new int[random.Next(15)];

Console.Write("Unsorted\n[");

for(int i = 0; i < ints.Length; i++)
{
    ints[i] = random.Next(0, 2000);
    Console.Write($"{ints[i]},");
}

Console.WriteLine("]");

// Sort the Values with QuickSort
QuickSort<int> quickSort = new();

// This is in-place sorting so no need to re-assign to ints
quickSort.Sort(ints, 0, ints.Length - 1);

Console.Write("Sorted\n[");

for(int i = 0; i < ints.Length; i++)
    Console.Write($"{ints[i]},");

Console.WriteLine("]");