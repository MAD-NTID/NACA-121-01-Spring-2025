public class Stack<T> : IStack<T>
{
    public int Count { get; private set; }
    public Node<T> Top { get; private set; }

    public Stack()
    {
        Count = 0;
        Top = null;
    }

    public void Clear()
    {
        Count = 0;
        Top = null;
    }

    public bool Contains(T element)
    {
        if(Top is null)
            return false;

        Node<T> currentTop = Top;

        while(currentTop is not null)
        {
            bool match = EqualityComparer<T>.Default.Equals(element, currentTop.Data);

            // If the match is found return true
            if(match)
                return true;

            // Moves the currentTop to the next Top
            currentTop = currentTop.Next;
        }

        // If a match was never found
        return false;
    }

    public T Peek()
    {
        return Top.Data;
    }

    public T Pop()
    {
        //  Temporary store the current Top data
        T temp = Top.Data;
        
        //  Set the Next element on the stack as the new Top
        Top = Top.Next;
        
        //  Because we have a new Top, we conceptually removed the previous
        //  Top from the stack, so.... minus 1 for the Count
        Count --;

        //  Return the previous Top
        return temp;
    }

    public void Push(T element)
    {
        // Copy the current Top to a temp
        Node<T> currentTop = Top;

        // Update the Top with the new Top and tell it who is next (previous currentTop)
        Top = new Node<T>(element, currentTop);

        // Incremement the count of nodes
        Count ++;
    }

    public T[] ToArray()
    {
        T[] elements = new T[Count];

        Node<T> currentTop = Top;

        int index = 0; 
        while(currentTop is not null)
        {
            elements[index++]  = currentTop.Data;
            currentTop = currentTop.Next;

        }

        return elements;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> currentTop = Top;

        while(currentTop is not null)
        {
            yield return currentTop.Data;
            currentTop = currentTop.Next;
        }
    }

    public override string ToString()
    {
        if(Top is null)
            return "null";

        return Top.ToString();
    }
}