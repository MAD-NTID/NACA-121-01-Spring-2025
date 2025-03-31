public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    public int Count { get; private set; }

    // This Capacity is to keep track of the array
    // It will help us to know if we need to expand it
    public int Capacity { get; private set; }
    // This is the default size for the array when instantiating the Dictionary
    const int DEFAULT_CAPACITY = 5;

    // This creates an Array of IKeyValuePair<TKey, TValue>
    // Similar to int[] which creates an Array of Int
    public IKeyValuePair<TKey, TValue>[] hashTable;

    // this constructor allows you to start with the different capacity
    // if you do not want the default capacity of 5
    public Dictionary(int capacity)
    {
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
        int index = GetIndex(key);

        if(ContainsKey(key))
            throw new ArgumentException($"Duplicate Key {key} not allowed");

        hashTable[index] = new KeyValuePair<TKey, TValue>(key, value);
        Count ++;
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool ContainsKey(TKey key)
    {
        int index = GetIndex(key);

        IKeyValuePair<TKey, TValue> kvpFromTheHashTable = hashTable[index];

        // if it returns null, it means there's no duplicate
        // Additional Note for clarity:
        // if kvpFromTheHashTable is null - this means the index position is available and has no value - so, it can be used to be added to that index - it also means, nothing can be removed from this index because there's nothing in it.

        // if(kvpFromTheHashTable is null)
        //     return true;
        // else
        //     return false;

        return kvpFromTheHashTable is not null;
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

        return hashTable[GetIndex(key)];
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
        int index = GetIndex(key);

        // this essentially "removes" the kvp by assigning null to the space
        hashTable[index] = null;

        Count --;

        return true;
    }
}