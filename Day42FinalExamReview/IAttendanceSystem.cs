public interface IAttendanceSystem
{
    public void LoadAttendance(string filePath);
    public void SaveAttendance(string filePath);
    public void AddStudent(string firstname, string lastname, List<DateTime> attendanceDates);
    public void AddStudent(string firstname, string lastname, DateTime attendanceDates);
    public List<IStudent> SortStudentsByLastName();
    public List<IStudent> SelectStudentsByDateRange(DateTime from, DateTime to);
    public Dictionary<string, IStudent> GetStudents();
}