Ship ship = new Ship("Voyager", 3000);

// Menu options for the user
string[] menus = {
    "Add Alien to ship",
    "Fly",
    "Fly at specific speed",
    "Remove an alien from the ship",
    "Show ship information",
    "Exit"
};

while (true)
{
    try
    {
        int selection = Selection();
        switch (selection)
        {
            case 1:
                // Adding an Alien to the ship
                Alien alien;
                bool added = false;
                string name;
                
                do
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    
                    Console.Write("Role: ");
                    string role = Console.ReadLine();
                    
                    alien = new Alien(name, role);
                    added = ship.Add(alien);
                    
                    if (!added)
                        Console.WriteLine("Only 1 Captain or Chief Officer allowed!");
                    
                } while (!added);
                
                Console.WriteLine($"Alien {alien} added!");
                break;

            case 2:
                // Fly the ship at default speed
                ship.Fly();
                Console.WriteLine($"{ship.ShipName} flew {ship.Distance} interstellar distance at {ship.WarpSpeed} warp speed");
                break;
            
            case 3:
                // Fly the ship at a specific warp speed
                Console.Write("Enter the warp speed (multiple of 3): ");
                
                if (!int.TryParse(Console.ReadLine(), out int speed) || speed % 3 != 0)
                {
                    Console.WriteLine("Invalid speed! Speed must be an integer multiple of 3!\nShip did not fly!");
                }
                else
                {
                    ship.Fly(speed);
                    Console.WriteLine($"{ship.ShipName} flew {ship.Distance} interstellar distance at {ship.WarpSpeed} warp speed");
                }
                break;

            case 4:
                // Remove an Alien from the ship
                Console.Write("Alien's name: ");
                name = Console.ReadLine();
                bool removed = ship.Remove(name);
                
                if (!removed)
                {
                    Console.WriteLine($"{name} doesn't exist!");
                }
                else
                {
                    Console.WriteLine($"{name} successfully removed");
                }
                break;

            case 5:
                // Display ship information
                Console.Write(ship);
                break;
            
            case 6:
                // Exit the program
                Console.WriteLine("Thank you for exploring space with us!");
                Environment.Exit(0);
                break;
            
            default:
                Console.WriteLine("Invalid selection!");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid selection. Input must be a digit!");
    }
}

// Displays the menu and retrieves user selection
int Selection()
{
    Console.WriteLine("Starfleet Federation");
    Console.WriteLine();
    Console.WriteLine("Menu\n================");
    
    for (int i = 1; i <= menus.Length; i++)
    {
        Console.WriteLine($"{i} - {menus[i - 1]}");
    }
    
    Console.Write("Selection: ");
    return int.Parse(Console.ReadLine());
}