List<Classroom> classrooms = new();

Classroom classroom1 = new("Programming 1", "LBJ", "2355", "10", "12");
classroom1.AddStudent("Usfer", 18, 1);
classroom1.AddStudent("Nai", 18, 1);

Student student = new("Amber", 18, 1);
classroom1.AddStudent(student);

Console.WriteLine(classroom1);