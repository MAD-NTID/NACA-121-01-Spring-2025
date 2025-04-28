AttendanceSystem attendanceSystem = new AttendanceSystem();
bool exit = false;

// Loop the menu until the user decides to quit
while(!exit)
{
    Console.WriteLine($"\nAttendance System Menu:\n" + 
    $"1. Load Attendance Data from file\n" + 
    $"2. Save Attendance Data to file\n" + 
    $"3. Add Student Attendance\n" + 
    $"4. Sort Students by Last Name\n" + 
    $"5. Select Students by Date Range\n" + 
    $"6. Exit");
    Console.Write("Enter your choice (1-5): ");

    string choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            Console.Write("Enter the file path to load attendance data from: ");
            string loadFilePath = Console.ReadLine();
            attendanceSystem.LoadAttendance(loadFilePath);
            Console.WriteLine("Attendance data loaded successfully");
        break;

        case "2":
            Console.Write("Enter the file path to save attendance to: ");
            string saveFilePath = Console.ReadLine();
            attendanceSystem.SaveAttendance(saveFilePath);
            Console.WriteLine("Attendance data saved successfully");
        break;

        case "3":
            Console.Write("Enter Student First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Student Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter the Attendance Date (yyyy-MM-dd): ");
            string attendanceDate = Console.ReadLine();

            // A list? Why? Because the system allows multiple attendances
            // to be added at once, so might as well just turn everything
            // into a list - even if it's just one date
            List<DateTime> attendances = [];

            // this comma so that multiple attendances are supported
            if(attendanceDate != null && attendanceDate.Contains(","))
            {
                // Select all of the delimited , attendances entered
                // and for each, convert them to a Datetime object.
                attendances = attendanceDate.Split(",")
                    .Select(x => DateTime.Parse(x))
                    .ToList();
            }

            // first if statement, to insert multiple attendance
            if(attendances.Count > 0)
                attendanceSystem.AddStudent(firstName, lastName, attendances);

            // else, to insert a single attendance
            else
                attendanceSystem.AddStudent(firstName, lastName, DateTime.Parse(attendanceDate));
        break;

        case "4":
            List<IStudent> sortedStudents = attendanceSystem.SortStudentsByLastName();
            Console.WriteLine("Students Sorted by Last Name --");
            foreach(IStudent student in sortedStudents)
                Console.WriteLine($"\t{student}");
        break;

        case "5":
            Console.Write("Enter the Start Date as yyyy-MM-dd: ");
            DateTime from = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the end Date as yyyy-MM-dd: ");
            DateTime to = DateTime.Parse(Console.ReadLine());

            List<IStudent> studentsInRange = attendanceSystem.SelectStudentsByDateRange(from, to);
            Console.WriteLine($"\nStudents who attended class between {from.ToShortDateString()} and {to.ToShortDateString()} -- ");
            foreach(IStudent student in studentsInRange)
                Console.WriteLine($"\t{student}");
        break;

        case "6":
            exit = true;
            Console.WriteLine("Exiting the Program...");
        break;

        default:
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
        break;
    }
}