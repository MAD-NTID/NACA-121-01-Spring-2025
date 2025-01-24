string[] studentNames = new string[5];

studentNames[0] = "Yarin";
studentNames[1] = "Skylar";
studentNames[2] = "Amber";
studentNames[3] = "Nai";
studentNames[4] = "Usfer";

// Iterate over the array starting with index 0 up to the length of the array
for(int i = 0; i < studentNames.Length; i++) 
{
    Console.WriteLine($"Student at position {i + 1} is {studentNames[i]}");
}