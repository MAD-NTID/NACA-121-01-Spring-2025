Alien talos = new Alien("Talos", 100);
Human nai = new Human("Nai", 18);

Console.WriteLine(talos);
Console.WriteLine($"Talks: {talos.Talk()}");
Console.WriteLine($"Runs: {talos.Run()}");
Console.WriteLine();
Console.WriteLine(nai);
Console.WriteLine($"Talks: {nai.Talk()}");
Console.WriteLine($"Run: {nai.Run()}");