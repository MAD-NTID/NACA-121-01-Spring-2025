IBeast godzilla = new Godzilla();
godzilla.Name = "Mega Godzilla";

Beast dragon = new Dragon();
dragon.Name = "Bahamut";

Console.WriteLine($"Godzilla's name is {godzilla.Name}");
Console.WriteLine($"Dragon's name is {dragon.Name}");


Console.WriteLine($"Dragon's dad and himself greet {dragon.HelloWorld()}");