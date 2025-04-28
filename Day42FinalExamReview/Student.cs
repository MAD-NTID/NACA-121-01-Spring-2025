
public class Student : IStudent
{
    public string? FirstName { get; private set; }

    public string? LastName { get; private set; }

    public List<DateTime> AttendanceDates { get; private set; }

    public Student(string? firstName, string? lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        AttendanceDates = [];
        // AttendanceDates = new() or
        // AttendanceDates = new List<DateTime>();
    }

    public void AddAttendance(DateTime date)
    {
        AttendanceDates.Add(date);
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}