public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    public int Count { get; private set; }

    // This Capacity is to keep track of the array
    // It will help us to know if we need to expand it
    public int Capacity { get; private set; }

    private const double LOAD_FACTOR = .70;
    public double LoadFactor { get; private set; }

    // This is the default size for the array when instantiating the Dictionary
    const int DEFAULT_CAPACITY = 5;

    // This creates an Array of IKeyValuePair<TKey, TValue>
    // Similar to int[] which creates an Array of Int
    public IKeyValuePair<TKey, TValue>[] hashTable;

    // this constructor allows you to start with the different capacity
    // if you do not want the default capacity of 5
    public Dictionary(int capacity)
    {
        LoadFactor = LOAD_FACTOR;

        // Long way
        // if(capacity < 0)
        //     capacity = DEFAULT_CAPACITY;

        // This is called a ternary operator
        Capacity = capacity < 0 ? DEFAULT_CAPACITY : capacity;
        Count = 0;

        // Initializes the hashTable with the determined capacity
        hashTable = new IKeyValuePair<TKey, TValue>[capacity];
    }

    // This is the default constructor, no parameters
    public Dictionary() : this(DEFAULT_CAPACITY) { }

    public void Add(TKey key, TValue value)
    {
        // When adding new items, first ensure that there's space
        // for inserting elements
        EnsureCapacity();

        int index = GetIndex(key);

        if(ContainsKey(key))
        {
            int location = LinearProbing(key);

            if(location == -1)
                throw new ArgumentException($"Duplicate Key {key} not allowed");
        }            

        hashTable[index] = new KeyValuePair<TKey, TValue>(key, value);
        Count ++;
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool ContainsKey(TKey key)
    {
        int index = LinearProbing(key, true);

        return index >= 0;
    }

    //  This is the only method that uses iteration to search for kvp by value
    //  Because a value is not a key and thus it can't be hashed
    //  A key can have the same definition or value
    public bool ContainsValue(TValue value)
    {
        foreach(IKeyValuePair<TKey, TValue> kvp in hashTable)
        {
            // We only want to compare the value, hence no key in EqualityComparer
            if(kvp is not null && 
                EqualityComparer<TValue>.Default.Equals(kvp.Value, value))
                    return true;
        }

        return false;
    }

    public IKeyValuePair<TKey, TValue> Get(TKey key)
    {
        if(!ContainsKey(key))
            throw new ArgumentException($"No such key {key} exists");

        return hashTable[LinearProbing(key, true)];
    }

    public int GetIndex(TKey key)
    {
        // Get the hash code for that key
        int hash = key.GetHashCode();

        // Gets the absolute value of the hash (avoids negative)
        hash = Math.Abs(hash);

        // Ensures you do not go above capacity or IndexOutOfBounds Exception
        // Avoids Divide by Zero Exception        
        int index = hash % Capacity;

        // Finall returns the hashed index position
        return index;
    }

    public bool Remove(TKey key)
    {
        // if the key does not exists, well, it can't be removed
        if(!ContainsKey(key))
            return false;

        // if it does exists, then we need hashed index to be able to 
        // remove it from the array
        // int index = GetIndex(key);
        int index = LinearProbing(key, true);

        // this essentially "removes" the kvp by assigning null to the space
        hashTable[index] = null;

        Count --;

        return true;
    }

    public void EnsureCapacity()
    {
        // Determine how close to the threshold (LOAD FACTOR) is the array currently at
        double loadFactor = Count / Capacity;

        if(loadFactor >= LoadFactor)
        {
            // Grow the capacity by double
            Capacity *= 2;

            // Create the new temporary array with the new capacity
            IKeyValuePair<TKey, TValue>[] tempHashTable = new KeyValuePair<TKey, TValue>[Capacity];

            // Now we need to copy the values from the old hashTable to the new tempHashTable
            for(int i = 0; i < hashTable.Length; i++)
            {
                tempHashTable[i] = hashTable[i];
            }

            // Finally, update the hash table
            hashTable = tempHashTable;
        }
    }

    public int LinearProbing(TKey key, bool searchExistingKey = false)
    {
        int startIndex = GetIndex(key);

        // Initialize index to start probing without touching the original index
        int index = startIndex;

        do
        {
            // Gets the current kvp stored in the hashTable
            IKeyValuePair<TKey, TValue> kvp = hashTable[index];

            // Search for existing index probing
            if(searchExistingKey && 
                kvp is not null && 
                EqualityComparer<TKey>.Default.Equals(key, kvp.Key))
            {
                return index;
            }

            // We are probing for an available spot (avoids collision)
            else if(!searchExistingKey && kvp is null)
            {
                return index;
            }

            // This will move the index to another position to Probe
            index = (index + 1) % Capacity;
        } while(index != startIndex);

        // this means, we scanned the whole array and found no available spot
        return -1;
    }
}