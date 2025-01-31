// Let's create one person, assuming all data is already validated and good
Person person = new Person("Tony Stark", 32, 150.55, 5.72, "123-12-1234");

Console.WriteLine($"Person Created: {person.Name}");
Console.WriteLine($"Age is: {person.Age}");
Console.WriteLine($"Weight is {person.Weight} and Height is {person.Height}");
Console.WriteLine($"The last four of SSN is {person.SSN}");