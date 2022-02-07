using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace GenericsHomework;

    public class CircularlyLinkedList<T>

       
    {

    //public int Size { get; private set; } = 0;
    public Node<T>? Cursor { get; set; }
    public Node<T>? Head { get; set; }
    public int Size { get; private set; } = 0;
    
    public T this[int index]
    {
        get => ReturnType(index)!; // if null, exception is thrown  
    }




    

    public void Append(Node<T> newNode)
    {
        

        //Size++;


    }

    public void Clear()
    {

    }
    public bool Exists(int index)
    {
        return false;
    }
    public T? ReturnType(int index)
    {
        Node<T> CursorTemp = Cursor!;//about to be null checked
        if (Cursor is null || Head is null) throw new InvalidOperationException();
        else if (index == Cursor.Index)
        {
            return Cursor.NodeType;
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


    public class Node<TNodeType>
    //where T : notnull, new()

    {
        
        public Node<TNodeType> Next { get; private set; }
        public int Index { get; set; }

        public Node(T t, Node<TNodeType>? next, int index)
        {
            if (next is null)
            {
                Next = this;
            }
            else
            {
                Next = next;
            }
            NodeType = t;
        }

        //public void SetNext(Node<TNodeType> next)
        //{
        //    Next = next;
        //}
        
        [DisallowNull]
        public T NodeType { get; set; }
        


        public override string ToString()
        {
            return "Node of type " + typeof(T); //+ " with index: " + Index;
        }

    }


}

