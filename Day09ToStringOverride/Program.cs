// Create a person
Person person = new Person("Tony", 32, 150, 5.72, "123-12-1234");
Person person2 = new Person("Hulk", 32, 150, 5.72, "123-12-1234");

// ToString is implicit
Console.WriteLine(person);
Console.WriteLine();

// Or you can do explicit, won't make a difference
Console.WriteLine(person2.ToString());