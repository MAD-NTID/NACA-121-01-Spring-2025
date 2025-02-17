public interface IArrayList
{    
    int Size { get; }
    public bool Add(int element);
    public void Add(int index, int element);
    public void Clear();
    public bool Contains(int element);

    // Gets the value of the given index position
    public int Get(int index);

    // Returns the index position of a given value
    public int IndexOf(int element);
    public bool IsEmpty();

    // Returns the index position of the last occurrence of element
    public int LastIndexOf(int element);
    public int RemoveAt(int index);
    public bool Remove(int element);
    public int Set(int index, int element);
}