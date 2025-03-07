using System.Reflection.Metadata.Ecma335;

public class Student
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public double GPA { get; private set; }

    public Student(string name, int age, double gpa) 
    {
        Name = name;
        Age = age;
        GPA = gpa;
    }

    public override string ToString()
    {
        return $"Student Name: {Name}\nAge: {Age}\nGPA: {GPA}";
    }
}