using System.Reflection;
using System.Text;

public class Classroom
{
    public string Title { get; private set; }
    public string Building { get; private set; }
    public string RoomNumber { get; private set; }
    public TimeOnly StartTime { get; private set; }
    public TimeOnly EndTime { get; private set; }

    // Hold a List of Student(s) per Classroom
    public List<Student>? Students { get; private set; }

    public Classroom() 
    {
        Title = "Not Set";
        Building = "Not Set";
        RoomNumber = "Not Set";
        Students = new();
    }

    public Classroom(string title, string building, string roomNumber, string startTime, string endTime, List<Student>? students = null)
    {
        Title = title;
        Building = building;
        RoomNumber = roomNumber;
        StartTime = new TimeOnly(int.Parse(startTime));
        EndTime = new TimeOnly(int.Parse(endTime));

        // If students is null, then initialize it, otherwise, use it
        // Master's shortcut "wink wink"
        Students = students ?? [];
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddStudent(string name, int age, int academicYear)
    {
        AddStudent(new Student(name, age, academicYear));
    }

    public override string ToString()
    {
        StringBuilder info = new();

        info.AppendLine($"Classroom: {Title}");
        info.AppendLine($"Title: {Title}");
        info.AppendLine($"Where: {Building} - {RoomNumber}");
        info.AppendLine($"When: {StartTime}");
        info.AppendLine("Students: ");

        if(Students.Count > 0)
            foreach(Student student in Students)
            {
                info.AppendLine($"\t{student}");
                info.AppendLine();
            }
        else
            info.AppendLine("No Students are Registered for this class");

        return info.ToString();
    }
}