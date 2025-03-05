public class Cars
{
    // By default, if no OS path is provided
    // then, path is project path (net9.0)
    // if using net8.0 it will be bin/debug/net8.0/cars.csv
    const string FILE_PATH = "cars.csv";

    private string[] cars = 
    {
        "make,model,year,mileage",
        "Chevrolet,S10,1996,195000",
        "Kia,Soul,2024,100",
        "Toyota,Camry,2020,67000"
    };

    public void WriteStream()
    {
        // 1) Create the StreamWriter Object
        StreamWriter sw = new(FILE_PATH);

        // 2) Perform a Loop to Store all the cars values from the array to the file
        foreach(string car in cars)
        {
            sw.WriteLine(car);   
        }

        // 3) Close the file once writing all cars value is completed
        sw.Close();
    }

    public bool StreamReader()
    {
        // 1) Check that the file exists
        if(File.Exists(FILE_PATH))
        {
            // 2) Open the file with StreamReader
            StreamReader sr = new(FILE_PATH);

            // 3) Because we are reading lines of text to an array, then we want to initialize an array large enough to store the number of lines
            // Use the same array in this class but with a new size
            cars = new string[100];

            // 4) Read each line and store to the array. 
            int currentLine = 0;

            //  Read until you reached the end of the file
            while(!sr.EndOfStream)
            {
                // 5) Store each line in its own index
                cars[currentLine++] = sr.ReadLine();
            }

            // 6) Close the stream reader
            sr.Close();

            return true;
        }

        return false;
    }

    public string GetCar(int row)
    {
        return cars[row];
    }

    public override string ToString()
    {
        string carsSummary = "";

        // Compile the list of all cars in to a nicely formatted string
        foreach(string car in cars)
        {
            // Ensure the line is not null or empty because if you split a null or empty line
            // you will get NullReferenceException
            if(!string.IsNullOrEmpty(car))
            {
                // Split the string into
                string[] thisCar = car.Split(",");
            carsSummary += $"{thisCar[0]}\t{thisCar[1]}\t{thisCar[2]}\t{thisCar[3]}\n";
            }
        }

        return carsSummary;
    }
}