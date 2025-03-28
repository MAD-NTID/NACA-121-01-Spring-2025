using System.Collections;

public class Queue<T> : IQueue<T>, IEnumerable<T>
{
    public int Count { get; private set; }
    private Node<T> front, back;

    public Queue()
    {
        front = null;
        back = null;
        Count = 0;
    }

    public void Clear()
    {
        front = null;
        back = null;
        Count = 0;
    }

    public bool Contains(T element)
    {
        Node<T> currentNode = front;

        while(currentNode is not null)
        {
            bool match = EqualityComparer<T>.Default.Equals(element, currentNode.Data);

            if(match)
                return true;

            currentNode = currentNode.Next;
        }

        // if a match was never found, then it's false
        return false;
    }

    public T Dequeue()
    {
        // Get the data of the node in the front and hold in temp
        T frontData = front.Data;

        // Update the new front to the next (node behind)
        front = front.Next;

        Count--;

        // Return which node was in the front before updating the new front
        return frontData;
    }

    public void Enqueue(T element)
    {
        Node<T> newNode = new Node<T>(element);
        Count++;

        if(front is null)
        {
            front = back = newNode;

            // Or the traditional way
            // front = newNode;
            // back = newNode;   

            return;
        }

        //  this tells the current node who is behind it
        back.Next = newNode;

        //  this updates the queue to who is in the back
        back = newNode;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> currentNode = front;

        while(currentNode is not null)
        {
            yield return currentNode.Data;
            currentNode = currentNode.Next;
        }
    }

    // this implementation tells the code which GetEnumator() to use, in this case
    // it will use our customized GetEnumerator() rather than Microsoft C# Default
    // GetEnumerator.
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public T Peek()
    {
        return front.Data;
    }

    public T[] ToArray()
    {
        T[] elements = new T[Count];
        Node<T> currentNode = front;
        int index = 0; 

        while(currentNode is not null)
        {
            elements[index++] = currentNode.Data;
        }

        return elements;
    }

    public override string ToString()
    {
        if(front is null)
            return "null";

        return front.ToString();
    }
}