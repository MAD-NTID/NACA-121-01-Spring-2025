public class MergeSort<T>
{
    public T[] Sort(T[] elements)
    {
        T[] sorted = [];

        // Base Case - if the size of elements is 1, then return T[] elements
        if(elements.Length == 1)
            return elements;

        // Find the midpoint of T[] elements
        int midpoint = elements.Length / 2;

        T[] left = Copy(elements, 0, midpoint);
        T[] right = Copy(elements, midpoint, elements.Length);

        // Now do recursion to continue splitting honoring the base case
        left = Sort(left);
        right = Sort(right);

        return Merge(left, right);
    }

    public T[] Merge(T[] arrayA, T[] arrayB)
    {
        // Create a sorted array with both lengths from arrayA and arrayB combined
        T[] sorted = new T[arrayA.Length + arrayB.Length];

        int indexA = 0, indexB = 0, indexSorted = 0;

        // This is where the merge happens for two given arrays
        while(indexA < arrayA.Length && indexB < arrayB.Length)
        {
            // Compare returns either -1, 0, or 1
            if(Comparer<T>.Default.Compare(arrayA[indexA], arrayB[indexB]) <= 0)
            {
                // Increment after you used the variables
                sorted[indexSorted ++] = arrayA[indexA ++];
            }
            else
            {
                // Increment after you used the variables
                sorted[indexSorted ++] = arrayB[indexB ++];
            }
        }

        // Copy the remaining elements from the individual arrays
        while(indexA < arrayA.Length)
        {
            sorted[indexSorted ++] = arrayA[indexA ++];
        }

        while(indexB < arrayB.Length)
        {
            sorted[indexSorted ++] = arrayB[indexB ++];
        }

        return sorted;
    }

    public T[] Copy(T[] elements, int startLength, int endLength) 
    {
        // To maintain a positive subtraction, endLength is largest, and startLength is smaller
        // then endLength - startLength
        T[] copy = new T[endLength - startLength];

        int index = 0; 

        // Despite of the lengths, we are iterating indexes based on 0 using a for loop
        for(int i = startLength; i < endLength; i++)
            copy[index ++] = elements[i];

        return copy;
    }
}