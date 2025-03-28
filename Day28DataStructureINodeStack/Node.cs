public class Node<T>
{
    // This allows you to store any kind of data into data
    // Could be an object, int, string, etc
    public T? Data { get; set; }

    // This holds the next Node of the same type
    public Node<T>? Next { get; set; }

    public Node(T? data, Node<T>? next)
    {
        Data = data;
        Next = next;
    }

    // This overloaded constructor will invoke the primary constructor
    public Node(T data) : this(data, null)
    { }

    public override string ToString()
    {
        // Base Case for Recursion - If Next is null, simply return this node's data and null for the next object
        if(Next is null)
        {
            // This Node's data itself and the next (which is nothing) null
            // return Data.ToString() + "-->null";
            return $"{Data}-->null";
        }


        // return Data.ToString() + "-->" + Next.ToString();
        return $"{Data}-->{Next}";
    }
}