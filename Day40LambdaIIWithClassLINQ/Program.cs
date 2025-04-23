List<Person> people = new() {
    new Person("Yarin", 18),
    new Person("Amber", 18),
    new Person("Alex", 18),
    new Person("Anthony", 18),
    new Person("Nai", 18),
    new Person("Usfer", 18)
};

var peopleNameStartWithA = people.FindAll(
    person => person.Name.StartsWith('A')
);

Console.WriteLine($"Count of People's Name Start with Letter 'A': {peopleNameStartWithA.Count}");

foreach(Person person in peopleNameStartWithA)
    Console.WriteLine(person);

Console.WriteLine();
Console.WriteLine("Below are the ages of people before adding 5 years");
foreach(Person person in people)
    Console.WriteLine(person);

Console.WriteLine();
Console.WriteLine("Below are the ages of people 5 years later");
// We want to transform so we use select
var peopleAge5YearsLater = people.Select(
    person => new Person(
        person.Name,
        person.Age + 5
    )
);

foreach(Person person in peopleAge5YearsLater)
    Console.WriteLine(person);