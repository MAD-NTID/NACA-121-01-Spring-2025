using Microsoft.VisualBasic.FileIO;

// To add package, issue this command
//  dotnet add package Newtonsoft.Json
// then you need to install it
//  dotnet restore
using Newtonsoft.Json;

public class AttendanceSystem : IAttendanceSystem
{
    private Dictionary<string, IStudent> students;

    public AttendanceSystem()
    {
        students = [];
    }

    public void AddStudent(string firstname, string lastname, List<DateTime> attendanceDates)
    {
        // We have a list of dates to add for the students so we'll need a loop
        foreach(DateTime date in attendanceDates)
            AddStudent(firstname, lastname, date);
    }

    public void AddStudent(string firstname, string lastname, DateTime attendanceDate)
    {
        // You'll want to add the student only if it doesn't exist
        // Let the firstname and lastname be the key
        string key = $"{firstname} {lastname}";

        if(!students.ContainsKey(key))
            students[key] = new Student(firstname, lastname);

        // Invoke AddAttendance from the Student class
        // Each Student has their own attendance list
        students[key].AddAttendance(attendanceDate);
    }

    public Dictionary<string, IStudent> GetStudents()
    {
        return students;
    }

    public void LoadAttendance(string filePath)
    {
        // Before we load from file, we need to clear out the current dictionary
        // in the real world, you would first need to make sure that the filePath exists
        if(File.Exists(filePath))
            students = [];

        using(TextFieldParser parser = new TextFieldParser(filePath))
        {
            // This tells the parser that we are seeking values with a delimited character
            parser.TextFieldType = FieldType.Delimited;

            // Now we tell it, what character we are delimiting with
            parser.SetDelimiters(",");

            // We need to skip the first line which is usually a header
            bool header = true;
            // Run the parser while is not the end of data
            while(!parser.EndOfData)
            {
                // This logic is to skip the 1st line which is the header
                if(header)
                {
                    header = false;
                    parser.ReadFields();
                    continue;
                }

                string[] fields = parser.ReadFields();
                string firstName = fields[0];
                string lastName = fields[1];
                
                // from index position 2 and ahead are dates
                // so let's take this time to create the Student object
                Student student = new(firstName, lastName);
                // from index position 2 and ahead are dates
                for(int i = 2; i < fields.Length; i++)
                {
                    student.AddAttendance(
                        // The date is currently a string, convert it to DateTime object
                        DateTime.Parse(fields[i])
                    );
                }

                // Finally, add the student to the dictionary to complete the "load"
                string key = $"{firstName} {lastName}";
                students[key] = student;
            }
        }
    }

    public void SaveAttendance(string filePath)
    {
        string json = JsonConvert.SerializeObject(
            students.Values, Formatting.Indented
        );

        File.WriteAllText(filePath, json);
    }

    public List<IStudent> SelectStudentsByDateRange(DateTime from, DateTime to)
    {
                //  Get All the Values, and then, Query
                //  student is temporary variable for 'each' Student object
                //  student => means for this student object, do what's next
        return students.Values.Where(student => 
            // for this student object, get any of the values (date in this case)
            // matching the conditions specified in 
            // date => means for this date object, do what's next
            student.AttendanceDates.Any(date => 
                // ensure that this date object is between two given dates
                date >= from && date <= to)
        // finall, satisfy the return type which is List<IStudent>
        ).ToList<IStudent>();
    }

    public List<IStudent> SortStudentsByLastName()
    {
        // Let's use insertion sort algorithm to sort the students by last name
        List<IStudent> sorted = students.Values.ToList<IStudent>();

        for(int i = 1; i < sorted.Count; i++)
        {
            IStudent current = sorted[i];
            int j = i - 1;

            while(j >= 0 && string.Compare(sorted[j].LastName, current.LastName) > 0)
            {
                sorted[j + 1]  = sorted[j];
                j--;
            }

            sorted[j + 1] = current;
        }

        return sorted;
    }
}