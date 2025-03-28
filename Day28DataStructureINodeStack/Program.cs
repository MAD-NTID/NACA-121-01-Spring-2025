// Node<string> Michael = 
//     new Node<string>("Michael", 
//         new Node<string>("Yarin", 
//             new Node<string>("Amber", 
//                 new Node<string>("Nai", 
//                     new Node<string>("Usfer")
//                     )
//                 )
//             )
//         );

// Console.WriteLine(Michael);

Stack<string> people = new Stack<string>();
people.Push("Michael");
people.Push("Yarin");
people.Push("Amber");
people.Push("Nai");
people.Push("Usfer");

Console.WriteLine(people);

// I can also use foreach because I implemented IEnumerator
foreach(var person in people)
{
    Console.WriteLine(person);
}