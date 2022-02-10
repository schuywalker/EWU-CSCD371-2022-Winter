using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework;
public class Node<T>
where T : notnull

{

    [DisallowNull]
    public Node<T> Next { get; private set; }
    public T Value { get; private set; }


    public Node(T value)
    {
        if (value is null) throw new ArgumentNullException("value cant be null");
        Value = value;
        Next = this;
    }


    public void Append(T value)
    {
        if (Exists(value))
        {
            throw new InvalidOperationException("Can't append duplicate values");
        }
        Node<T> newNode = new(value);
        newNode.Next = this.Next;
        this.Next = newNode;
    }

    public Node<T> Clear()
    {
        Next = this;
        return this;
    }
    public bool Exists([DisallowNull] T value)
    {
        if (this.Value.Equals(value)) return true;
        else if (this.Next == this) return false; //this is not of the queried type and there are no other nodes in the list
        Node<T> cursor = this.Next;
        while (cursor != this)
        {
            if (cursor.Value.Equals(value)) return true;
            cursor = cursor.Next;
        }
        return false;
        
    }
    



    public override string ToString()
    {
        return "Node of type " + typeof(T);
    }

}



