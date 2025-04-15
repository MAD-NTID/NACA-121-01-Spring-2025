public class QuickSort<T>
{
    public void Sort(T[] values, int low, int hi)
    {
        // base case to stop sorting recursion and avoid stack overflow
        if(low >= hi || low < 0)
            return;

        int pivot = Partition(values, low, hi);

        Sort(values, low, pivot - 1);
        Sort(values, pivot + 1, hi);
    }

    public int Partition(T[] values, int low, int hi)
    {
        T p = values[hi];

        int i = low - 1;

        for(int j = low; j < hi; j++)
        {
            // -1 is left is less than right
            //  0 is left and right equal
            //  1 is left is greater than right
            if(Comparer<T>.Default.Compare(values[j], p) <= 0)
            {
                i += 1;

                Swap(values, i, j);
            }
        }

        i += 1;

        Swap(values, i, hi);

        return i;
    }

    public void Swap(T[] values, int from, int to)
    {
        //  Create a temporary variable of generic type and store the value from the array at position from
        T fromValue = values[from];

        //  Replace the value at position from with the value at position to
        values[from] = values[to];

        //  Replace the value at position to with the value in the temporary variable
        values[to] = fromValue;
    }
}