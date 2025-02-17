// Let's create a fixed array of 3 int
int[] numbers = new int[3];

numbers[0] = 10;
numbers[1] = 15;
numbers[2] = 20;

// Exception will occur here, why? So we need to grow the array to make room
// for a Fourth Element, but, C# has no such method to "grow" an array

// Usfer - Make an object of the object for numbers array
// Nai - Create a new array (you can't add elements yet, )
// Passing the old array to the new one
// Copy over the values from the old array to the new
// Replace the old array with the new one
int[] numbersCopy = new int[numbers.Length + 1];

// Copy over the old values to the new array
for(int i = 0; i < numbers.Length; i++)
{
    numbersCopy[i] = numbers[i];
}

// Finally, replace the old array with the new one
numbers = numbersCopy;

numbers[3] = 25;

// Let's prove it
for(int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{i + 1}: {numbers[i]}");
}