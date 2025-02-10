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
        // Check if the new alien's role is either "captain" or "chief officer"
        // and ensure there's only one of each in the aliens list.
        if(alien.Role.Equals("captain", StringComparison.CurrentCultureIgnoreCase) || 
            alien.Role.Equals("chief officer", StringComparison.CurrentCultureIgnoreCase)) {
            
            // Loop through the aliens array to check if a captain or chief officer already exists
            for(int i = 0; i < aliens.Length; i++)
            {
                // If an existing alien has the same role, return false (cannot add duplicate role)
                if(aliens[i] != null && aliens[i].Role == alien.Role)
                    return false;
            }
        }

        // Check crew counter is not over capacity
        if(crewCount > aliens.Length)
            return false;

        // Find the first available (null) slot in the aliens array to add the new alien
        for(int i = 0; i < aliens.Length; i++)
        {
            if(aliens[i] == null) // Empty spot found
            {
                aliens[i] = alien; // Assign the new alien to this spot
                crewCount++; // Increment the crew count
                break; // Stop the loop once the alien is added
            }
        }

        return true; // Return true indicating the alien was successfully added
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