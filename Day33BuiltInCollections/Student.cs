public class Student
{
    public string? Name { get; private set; }
    public int Age { get; private set; }
    public int AcademicYear { get; private set; }

    public Student(string name, int age, int academicYear)
    {
        Name = name;
        Age = age;
        AcademicYear = academicYear;
    }

    public override string ToString()
    {
        return $"Name: {Name}\n\tAge: {Age}\n\tAcademic Year: {AcademicYear}";
    }
}