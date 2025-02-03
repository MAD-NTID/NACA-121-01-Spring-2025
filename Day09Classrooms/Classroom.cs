using System.Text.RegularExpressions;

class Classroom
{
    private Student[] students;
    private int studentsCount;

    private string className;
    public string ClassName
    {
        get { return className; }
        set { className = string.IsNullOrEmpty(value) ? "Undefined" : value; }
    }
    
    private string roomNumber;
    public string RoomNumber
    {
        get { return roomNumber; }
        set 
        { 
            Regex regex = new Regex("^[a-zA-Z]{3}-\\d{4}$");
            
            roomNumber = regex.IsMatch(value) ? value : "N/A";
        }
    }
    
    // This default constructor initializes a classroom list of number of students
    public Classroom()
    {
        students = new Student[100];
    }

    public Classroom(string className, string roomNumber)
    {
        // students = new Student[100];
        new Classroom();

        // Initialize the properties
        ClassName = className;
        RoomNumber = roomNumber;
    }

    public void AddStudent(Student student) 
    {
        // Iterate the student array and find an empty spot to put in the Student object
        for(int i = 0; i < students.Length; i++)
        {
            // if(students[i] == null)
            if(students[i].Equals(null))
            {
                students[i] = student;
                studentsCount++;

                // Don't let the students count go above the student's array length
                if(studentsCount > students.Length)
                    studentsCount = students.Length;

                break;
            }
        }
    }

    public void RemoveStudent(int studentIndex)
    {
        // This will "remove" a student
        students[studentIndex] = null;

        studentsCount--;

        // Don't let the students count go below 0
        if(studentsCount < 0)
            studentsCount = 0;
    }

    // Or you can count students using a loop
    public int StudentsCount()
    {
        int count = 0;

        for(int i = 0; i < students.Length; i++)
        {
            if(students[i] != null)
                count++;
        }

        return count;
    }

    public override string ToString()
    {
        return $"Class Name: {className}\n" +
                $"# of Students: {StudentsCount()}";
    }
}