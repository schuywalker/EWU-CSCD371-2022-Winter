using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace GenericsHomework;

public class CircularlyLinkedList<T>
    where T : notnull

{

    public Node<T>? Tail { get; set; }
    public Node<T>? Head { get; set; }
    public int Size { get; private set; } = 0;

    public T this[int index]
    {

        get
        {
            if (Tail is null || Head is null) throw new InvalidOperationException();
            else
            {
                return ReturnType(index)!; // if null, exception is thrown  
            }

        }
    }




    public void Append([DisallowNull] T t) // with no set next, append will need node to set next in constructor, and append will
        //need to make new(). therefore append must be in the Node class.
    {
        if (Head is null || Tail is null)
        {

            Node<T> newNode = new(t, 0);
            Head = newNode;
            Tail = newNode;
        }
        else
        {

            Node<T> temp = new(t, Tail, Tail.Index + 1);
            
        }
        Size++;
    }

    public void Clear()
    {

    }
    public bool Exists(int index)
    {
        return false;
    }
    public T ReturnType(int index)
    {
        
        Node<T> CursorTemp = Tail!;//about to be null checked
        if (Tail is null || Head is null) throw new InvalidOperationException();
        else if (index == Tail.Index)
        {
            return Tail.NodeType;
        }

        else if (CursorTemp.Index < index)
        {

            while (CursorTemp.Index < index)
            {
                CursorTemp = CursorTemp.Next;
            }
            return CursorTemp.NodeType;
        }
        else
        {
            CursorTemp = Head;
            while (CursorTemp.Index < index)
            {
                CursorTemp = CursorTemp.Next;
            }
            return CursorTemp.NodeType;
        }
    }



    public class Node<TNodeData>
    where TNodeData : notnull

    {

        [DisallowNull]
        public Node<TNodeData> Next { get; private set; }
        public int Index { get; set; }
        
        [DisallowNull]
        public TNodeData NodeType { get; set; }

        public Node([DisallowNull] TNodeData t, int index)
        { // type of Node is always T, but once it's in node, we call it TNodeData

            NodeType = t;
            Next = this;
            Index = index;
        }
        

        public Node([DisallowNull] TNodeData t, Node<TNodeData> Tail, int index)
        { // type of Node is always T, but once it's in node, we call it TNodeData

            NodeType = t;
            Index = index;

            Next = Tail.Next;// AKA Head
            Tail.Next = this;
            Tail = this;

           
        }


        public override string ToString()
        {
            return "Node of type " + typeof(T) + " with index: " + Index;
        }

    }


}

// interesting interview question:
// im writing method, you pass me node, return whether the node in question eventually ends in null or circles back on itself