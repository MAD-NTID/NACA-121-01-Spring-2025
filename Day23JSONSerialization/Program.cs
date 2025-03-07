using Newtonsoft.Json;

Student student1 = new("Yarin", 18, 4.0);
Student student2 = new("Usfer", 18, 4.0);

Student[] students = 
[
    student1,
    student2
];

string serializedStudents = JsonConvert.SerializeObject(students);
Console.WriteLine(serializedStudents);

const string FILE_PATH = "students_serialized.json";
StreamWriter writer = new(FILE_PATH);
writer.Write(serializedStudents);
writer.Close();
Console.WriteLine($"Finished Writing Serialized Students to file name {FILE_PATH}");

StreamReader reader = new(FILE_PATH);
Student[] deserializedStudents = JsonConvert.DeserializeObject<Student[]>(reader.ReadToEnd());
reader.Close();

Console.WriteLine($"Finished Reading from {FILE_PATH}");

for(int i = 0; i < deserializedStudents.Length; i++)
    Console.WriteLine(deserializedStudents[i]);