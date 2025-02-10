using System.Security.Cryptography.X509Certificates;

class Ship
{
    private int distance;
    public int Distance
    {
        get { return distance; }
    }
    
    private int warpSpeed;
    public int WarpSpeed
    {
        get { return warpSpeed; }
    }
    
    private string shipName;
    public string ShipName
    {
        get { return shipName; }
    }
    
    private Alien[] aliens;

    private int crewCount;

    // NOTE: At this point, captain and chiefOfficer are null
    private Alien captain, chiefOfficer;

    // Default constructor (no parameters)
    public Ship()
    {
        shipName = "Unidentified Flying Object";
        warpSpeed = 0;
        distance = 0;
        crewCount = 0;

        //  Initial Capacity
        aliens = new Alien[10];
    }

    // Parameterized constructor
    public Ship(string shipName, int capacity)
    {
        this.shipName = shipName;
        warpSpeed = 0;
        distance = 0;
        crewCount = 0;

        //  Initial Capacity
        aliens = new Alien[capacity];
    }

    // There can only be 1 captain and 1 chief officer on the ship
    public bool Add(Alien alien)
    {
        // How can we check if this new 'alien' role is captain or chief officer, but,
        // Make sure, there's only 1 captain and chief officer in the list of Aliens
        if(alien.Role.Equals("captain", StringComparison.CurrentCultureIgnoreCase)) {
            if (captain == null)
            {
                captain = alien;
                aliens[crewCount] = alien;
                crewCount++;
                return true;
            }
            else
                return false;
        }

        if(alien.Role.Equals("chief officer", StringComparison.CurrentCultureIgnoreCase) &&
            chiefOfficer == null)
        {
            chiefOfficer = alien;
        }
        else
            return false;

        // if it's not captain or chief officer, then it's a regular Alien crew
        if(crewCount < aliens.Length)
        {
            aliens[crewCount] = alien;
            crewCount++;

            return true;
        }

        return false;
    }

    public bool Remove(string name)
    {
        // Iterate all aliems
        for(int i = 0; i < aliens.Length; i++)
        {
            // Match by name
            if(aliens[i].Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
            {
                // Remove alien by assigning null to the index
                aliens[i] = null;

                // Decrease the crew count
                crewCount--;

                return true;
            }
        }

        return false;
    }

    // this one is incremental speed setting
    public void Fly()
    {
        warpSpeed += 3;
        distance += 5;
    }

    // this one is a manual speed setting
    public void Fly(int warpSpeed)
    {
        this.warpSpeed = warpSpeed;

        int multiply = warpSpeed / 3;
        distance = multiply * 5;
    }

    public override string ToString()
    {
        string returnString = "";

        /*
        Ship Name: <name>
        Speed: <current warp speed>
        Distance: <distance>
        Total Crew: <total>
        Crews:
        - name 1 role 1
        - name 2 role 2
        - name n role n
        */

        returnString += $"Ship {shipName}\n";
        returnString += $"Speed: {warpSpeed}\n";
        returnString += $"Distance: {distance}\n";
        returnString += $"TotalCrew: {crewCount}\n";

        string crewListing = "";
        for(int i = 0; i < aliens.Length; i++)
        {
            if(crewListing[i] != null)
            {
                crewListing += $"Name: {aliens[i].Name} Role: {aliens[i].Role}\n";
            }
        }

        returnString += crewListing;

        return returnString;
    }
}