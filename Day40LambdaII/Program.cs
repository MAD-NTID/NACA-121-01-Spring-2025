// // Example 1 - Count the NUmbers that are multiples of 2
List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
// //  Find all the numbers in the numbers list that are even
// List<int> evenNumbers = numbers.FindAll(num => num % 2 == 0);
// int evenCount = evenNumbers.Count;

// Console.WriteLine($"Count of Even Numbers: {evenCount}");

// foreach(int number in evenNumbers)
//     Console.WriteLine(number);

// // Example 2 - Select Transformation - Name and AgeInFiveYears

// var people = new[] {
//     new {Name = "Yarin", Age = 18}, // 18 + 5 = 23
//     new {Name = "Amber", Age = 21}, // 21 + 5 = 26
//     new {Name = "Nai", Age = 17}, // 17 + 5 = 22
//     new {Name = "Usfer", Age = 22} // 22 + 5 = 27
// };

// // Get a list transformed from the people, and calculate the age for 5 years later
// var peopleAgeIn5Years = people.Select(person => new {
//     person.Name,
//     ageIn5Years = person.Age + 5
// });

// foreach(var person in peopleAgeIn5Years)
//     Console.WriteLine($"Name: {person.Name} will be {person.ageIn5Years} years");

// Example 3 - Where filter - get all multiples of 3
// This Where is similar to what we did above with FindAll
var multiplesOf3 = numbers.Where(num => num % 3 == 0);

// NOTE: results will not be filtered until we run a foreach of it
foreach(int multipleOf3 in multiplesOf3)
    Console.WriteLine(multipleOf3);