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
    public int Index { get; set; }

    [DisallowNull]
    public T NodeType { get; set; }

    public Node([DisallowNull] T t)
    { 

        NodeType = t;
        Next = this;

    }


    public Node([DisallowNull] T t, [DisallowNull] Node<T> Tail)
    { 
        NodeType = t;

        Next = Tail.Next;// AKA Head
        Tail.Next = this;
        Tail = this;

    }
    public Node([DisallowNull] Node<T> node)
    {
        node.Next = node;
    }


    public override string ToString()
    {
        return "Node of type " + typeof(T) + " with index: " + Index;
    }

}



