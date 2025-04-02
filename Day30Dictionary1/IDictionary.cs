public interface IDictionary<TKey, TValue>
{
    // Keeps track of elements occupying spaces in the dictionary
    public int Count { get; }
    public double LoadFactor { get; }
    public void Clear(); 
    public bool ContainsKey(TKey key);
    public bool ContainsValue(TValue value);
    public void Add(TKey key, TValue value);
    public bool Remove(TKey key);
    public int GetIndex(TKey key);
    public void EnsureCapacity();
    public int LinearProbing(TKey key, bool searchExistingKey = false);

    // Return the Key Value Pair itself as well
    // The method name is Get, and parameter is a TKey
    // This will return IKeyValuePair
    public IKeyValuePair<TKey, TValue> Get(TKey key);
}