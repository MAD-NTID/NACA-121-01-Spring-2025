Person person1 = new Person("John");
Person person2 = new Person("John");

Console.WriteLine(person1 == person2); // false (reference point comparison)
Console.WriteLine(person1.Equals(person2)); // true (value comparison)

Console.WriteLine(
    // "hello world" - creates a string object
    // string objects have inherited method .Equals()
    // it is true, because we are passing the same value but upper case, and
    // ignoring the case sensitivity 
    "hello world".Equals("HELLO WORLD", StringComparison.CurrentCultureIgnoreCase)
);