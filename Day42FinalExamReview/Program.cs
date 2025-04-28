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
        break;
    }
}