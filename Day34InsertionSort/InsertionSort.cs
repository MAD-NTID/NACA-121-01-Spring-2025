public class InsertionSort<T>
{
    // Accepts an array of values
    // Returns array of values in ascending order
    // This method does In-Place Sorting (meaning, modifies the array directly)
    public T[] Sort(T[] elements)
    {
        // Do Sorting here...
        for(int i = 1; i < elements.Length; i++)
        {
            T x = elements[i];
            int j; 

            for(j = i; j > 0 && IsGreater(elements[j-1], x); j--) 
            {
                // This is the swap
                elements[j] = elements[j-1];
            }

            // this moves the element to the j position after it's done sorting above
            elements[j] = x;
        }

        return elements;
    }

    public bool IsSortedAscending(T[] elements)
    {
        Comparer<T> comparer = Comparer<T>.Default;

        // Iterate the elements to check for sorted array
        for(int i = 0; i < elements.Length; i++)
        {
            if(comparer.Compare(elements[i], elements[i - 1]) < 0)
                return false;
        }

        return true;
    }

    public bool IsGreater(T element1, T element2)
    {
        // The Comparer class will return -1 if ele1 is less than ele2
        // 0 if ele1 and ele2 are equal
        // 1 if ele1 is greater than ele2

        // We are interested in that element1 is greater than element2
        return Comparer<T>.Default.Compare(element1, element2) == 1;
    }

    public static implicit operator InsertionSort<T>(int v)
    {
        throw new NotImplementedException();
    }
}