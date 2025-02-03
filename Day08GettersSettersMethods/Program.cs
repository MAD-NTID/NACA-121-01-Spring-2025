// Let's create one person, assuming all data is already validated and good
Person person = new Person("Tony Stark", 32, 150.55, 5.72, "123-12-1234");

Console.WriteLine($"Person Created: {person.GetName()}");
Console.WriteLine($"Age is: {person.GetAge()}");
Console.WriteLine($"Weight is {person.GetWeight()} and Height is {person.GetHeight()}");
Console.WriteLine($"The last four of SSN is {person.GetSSN()}");

Console.WriteLine();

Person person2 = new Person();
person2.SetFirstName("Tony Stark");
person2.SetAge(32);
person2.SetWeight(150.55);
person2.SetHeight(5.72);
person2.SetSSN("123-12-1234");

Console.WriteLine($"Person Created: {person2.GetName()}");
Console.WriteLine($"Age is: {person2.GetAge()}");
Console.WriteLine($"Weight is {person2.GetWeight()} and Height is {person2.GetHeight()}");
Console.WriteLine($"The last four of SSN is {person2.GetSSN()}");