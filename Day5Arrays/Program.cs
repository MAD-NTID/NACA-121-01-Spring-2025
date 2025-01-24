// Create an array of int for student's ages
int[] studentAges = new int[5];

Console.WriteLine($"The size of the array is {studentAges.Length}");
Console.WriteLine($"Student 1: {studentAges[0]}");
Console.WriteLine($"Student 2: {studentAges[1]}");
Console.WriteLine($"Student 3: {studentAges[2]}");
Console.WriteLine($"Student 4: {studentAges[3]}");
Console.WriteLine($"Student 5: {studentAges[4]}");

// At this point, the above array has all values of 0
studentAges[0] = 18;
studentAges[1] = 19;
studentAges[2] = 20;
studentAges[3] = 21;
studentAges[4] = 22;

// Arrays are immutable (can't resize)
int[] studentAges2 = new int[studentAges.Length + 1];
studentAges2[0] = studentAges[0];
studentAges2[1] = studentAges[1];
studentAges2[2] = studentAges[2];
studentAges2[3] = studentAges[3];
studentAges2[4] = studentAges[4];
studentAges2[5] = 23;    // this is the new student age

// You can re-assign the array with the new one, throwing away the old values
// And replacing with the new values
studentAges = studentAges2;

Console.WriteLine("After Assigning Ages: ");
Console.WriteLine($"Student 1: {studentAges[0]}");
Console.WriteLine($"Student 2: {studentAges[1]}");
Console.WriteLine($"Student 3: {studentAges[2]}");
Console.WriteLine($"Student 4: {studentAges[3]}");
Console.WriteLine($"Student 5: {studentAges[4]}");
Console.WriteLine($"Student 6: {studentAges[5]}");