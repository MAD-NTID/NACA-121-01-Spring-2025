IBeast godzilla = new Godzilla("Mega Godzilla");
IBeast dragon = new Dragon("Bahamut");

Console.WriteLine(godzilla);
Console.WriteLine();
Console.WriteLine(dragon);
Console.WriteLine();

int round = 1;

while (godzilla.CurrentHealth > 0 && dragon.CurrentHealth > 0)
{
    Console.WriteLine($"===== Round {round++} =====\n");
    // Godzilla performs a regular attack against dragon
    godzilla.Attack(dragon);
    Console.WriteLine($"Dragon Status\n{dragon}");
    Console.WriteLine();

    // Check if dragon is defeated
    if (dragon.CurrentHealth <= 0)
    {
        Console.WriteLine("Dragon is defeated!");
        break;
    }

    // Dragon performs a regular attack against godzilla
    dragon.Attack(godzilla);
    Console.WriteLine($"Godzilla Status\n{godzilla}");
    Console.WriteLine();

    // Check if godzilla is defeated
    if (godzilla.CurrentHealth <= 0)
    {
        Console.WriteLine("Godzilla is defeated!");
        break;
    }

    // Godzilla performs an ability attack Spike against dragon
    godzilla.AbilityAttack(dragon);
    Console.WriteLine($"Dragon Status\n{dragon}");
    Console.WriteLine();

    // Check if dragon is defeated
    if (dragon.CurrentHealth <= 0)
    {
        Console.WriteLine("Dragon is defeated!");
        break;
    }

    // Dragon performs an ability attack Fire Breath against godzilla
    dragon.AbilityAttack(godzilla);
    Console.WriteLine($"Godzilla Status\n{godzilla}");
    Console.WriteLine();

    // Check if godzilla is defeated
    if (godzilla.CurrentHealth <= 0)
    {
        Console.WriteLine("Godzilla is defeated!");
        break;
    }

    Console.WriteLine();
}
