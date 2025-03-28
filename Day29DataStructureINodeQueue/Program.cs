// Create a queue of people wanting to pay for their food
Queue<string> people = new Queue<string>();

people.Enqueue("Amber");
Console.WriteLine($"Amber just got in line to pay for her coffee");

people.Enqueue("Yarin");
Console.WriteLine($"Yarin just got in line to pay for his protein shake, cuz he's all about muscles");

Console.WriteLine($"Looks like {people.Count} got in line while waiting for the lazy cashier who is on her phone... mean while");

people.Enqueue("Skylar");
Console.WriteLine($"Skylar just got in the line to pay for grill cheese, but he's too focused on his laptop and ignores the line... smart kid");

Console.WriteLine($"The cashier finally woke up, and processed the person in the front, {people.Dequeue()}");

Console.WriteLine($"{people.Peek()} got so desperate, it yelled at the cashier hurry up");

Console.WriteLine($"The cashier processed {people.Dequeue()}");

people.Enqueue("Usfer");
Console.WriteLine($"Usfer just got in the line to pay for his kebab (well, maybe 3 kebabs) he's so hungry");

Console.WriteLine($"Meanwhile, the cashier processes {people.Dequeue()}");

people.Enqueue("Nai");
Console.WriteLine($"Nai just got in the line to pay for her pink drink (can't miss that)");

people.Enqueue("Michael");
Console.WriteLine($"Michael just joined the line to pay for his Arroz con Gandulez and Cerdo Guisado - cuz damn hungry");

Console.WriteLine($"Cashier finally decided to process everyone");
Console.WriteLine($"Cashier processed {people.Dequeue()}");
Console.WriteLine($"Cashier processed {people.Dequeue()}");
Console.WriteLine($"Cashier processed {people.Dequeue()}");