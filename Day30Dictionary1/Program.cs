System.Collections.Generic.Dictionary<string, int> studentAges = new System.Collections.Generic.Dictionary<string, int>();

studentAges.Add("Yarin", 18);
bool yarinExists = studentAges.ContainsKey("Yarin");
int yarinIndex = studentAges.GetIndex("Yarin");

studentAges.Add("Skylar", 27);
bool skylarExists = studentAges.ContainsKey("Skylar");
int skylarIndex = studentAges.GetIndex("Skylar");


Console.WriteLine($"{studentAges.Get("Yarin")} - Exists: {yarinExists} at index {yarinIndex}");
Console.WriteLine($"{studentAges.Get("Skylar")} - Exists: {skylarExists} at index {skylarIndex}");

// Let's cause a collition on purpose
// studentAges.Add("Yarin", 18);

// Let's cause a collition by filling up the array
studentAges.Add("Amber", 18);
studentAges.Add("Nai", 18);
studentAges.Add("Usfer", 18);
studentAges.Add("Michael", 18); // collision may happen here...

studentAges.Add("Skylar's Son", 2);
studentAges.Add("Amber's Cat", 18);

Console.WriteLine($"{studentAges.Count} out of {studentAges.Capacity}");