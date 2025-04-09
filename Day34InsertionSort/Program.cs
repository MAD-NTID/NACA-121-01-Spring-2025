// Create an unsorted array of T values
InsertionSort<int> insertionSort = new();

// Instead of hardcoding an unsorted array, you can generate random numbers
// int[] unsorted = [5, 10, 2, 0, 1, 2];
Random random = new();

int[] unsorted = new int[random.Next(3, 10)];
for(int i = 0; i < unsorted.Length; i++)
    unsorted[i] = random.Next(0, 100);

// print values before sorting
for(int i = 0; i < unsorted.Length; i++)
    Console.Write($"{unsorted[i]} ");

Console.WriteLine();

int[] sorted = insertionSort.Sort(unsorted);

// print values after sorting
for(int i = 0; i < sorted.Length; i++)
    Console.Write($"{sorted[i]} ");

Console.WriteLine();