using System;

namespace GenericsHomework;

public class Node<T> 
    where T : notnull 
{
    public Node<T> Next { get; private set; }
    public int Index { get; set; }

    public Node(Node<T> next, int index)
    {
        if (next is null)
        {
            Next = this;
        }
        else
        {
            Next = next;
        }
        Index = index;
    }
    

    public override string ToString()
    {
        return "Node of type "+typeof(T) + " with index: "+Index;
    }

}

