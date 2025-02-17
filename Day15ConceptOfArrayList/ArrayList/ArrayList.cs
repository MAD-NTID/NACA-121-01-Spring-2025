public class IntArrayList : IArrayList
{
    const int DEFAULT_CAPACITY = 10;

    private int[] array;
    private int size;

    public IntArrayList()
    {
        array = new int[DEFAULT_CAPACITY];
    }

    public IntArrayList(int capacity)
    {
        array = new int[capacity];
    }

    public int Size()
    {
        return size;
    }

    public bool Add(int element)
    {
        throw new NotImplementedException();
    }

    public void Add(int index, int element)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(int element)
    {
        throw new NotImplementedException();
    }

    public int Get(int index)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(int element)
    {
        throw new NotImplementedException();
    }

    public bool IsEmpty()
    {
        throw new NotImplementedException();
    }

    public int LastIndexOf(int element)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int element)
    {
        throw new NotImplementedException();
    }

    public int RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public int Set(int index, int element)
    {
        throw new NotImplementedException();
    }

    //  This method will check if the array has reached capacity, and expand it if needed
    private void GrowArray()
    {
        if(size == array.Length)
        {
            // Double the Capacity
            int newCapacity = array.Length * 2;
            int[] newArray = new int[newCapacity];

            // Now we copy over the values to the newArray (temporary array)
            for(int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            // Finally, replace the old array with the new one
            array = newArray;
        }
    }
}