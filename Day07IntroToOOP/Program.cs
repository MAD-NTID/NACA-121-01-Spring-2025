// Let's create 5 Student objects
Student student1 = new Student();
student1.name = "Yarin";
student1.age = 18;
student1.major = "ACT";

Student student2 = new Student("Skylar", "ACT", 18, "123-12-1234");

Student student3 = new Student("Amber", "ACT", 18, "123-12-1234");

Student student4 = new Student("Nai", "ACT", 18, "123-12-1234");

Student student5 = new Student("Usfer", "ACT", 18, "123-12-1234");

Student student6 = new Student("", "", -10, "");

Student[] students = new Student[6];
students[0] = student1;
students[1] = student2;
students[2] = student3;
students[3] = student4;
students[4] = student5;
students[5] = student6;

for(int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"Student {i + 1}\nName: {students[i].name}\nAge: {students[i].age}\nMajor: {students[i].major}");

    Console.WriteLine();
}