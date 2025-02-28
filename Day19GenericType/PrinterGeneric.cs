public class Printer<T>
{
    // We create the array to hold values (printer jobs)
    // So this means, whatever type we instantiated with
    // that type the array will be
    private readonly T[] jobs;
    private int jobPositionPrinted, jobPositions;

    public int Size { get { return jobs.Length; }}

    public Printer(int capacity)
    {
        jobs = new T[capacity];
    }

    public bool Add(T value)
    {
        // ensure size is not greater than available array length
        if(jobPositions == jobs.Length)
            return false;

        // size++ means, use whatever value is there now, 
        // after consumed (used), increase by 1
        jobs[jobPositions++] = value;
        
        return true;
    }

    // Return type T because you don't know what the coder wants to use
    // this for, in other words, it can be string, int, double, etc.
    public T Print()
    {
        // if printed is 0, that means all the jobs have been printed
        // then we can start adding new jobs again
        if(jobPositions == jobPositionPrinted)
        {
            jobPositions = 0; 
            jobPositionPrinted = 0;
        }

        // start printing from the beginning of the print queue
        T document = jobs[jobPositionPrinted++];

        return document;
    }

    public bool Cancel(T job)
    {
        // search for the value of the job to remove from the array
        for(int i = 0; i < jobs.Length; i++)
        {
            if(EqualityComparer<T>.Default.Equals(jobs[i], job))
            {
                jobs[i] = default;
                return true;
            }
        }

        return false;
    }
}