using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace GenericsHomework;

public class CircularlyLinkedList<T>


{

    public Node<T>? Cursor { get; set; }
    public Node<T>? Head { get; set; }
    public int Size { get; private set; } = 0;

    public T this[int index]
    {
        
        get
        {
            if (Cursor is null || Head is null) throw new InvalidOperationException();
            else
            {
                return ReturnType(index)!; // if null, exception is thrown  
            }

        }
    }






    
    public void Append(Node<T> newNodeType)
    {
        if (Head is null || Cursor is null)
        {
            Node<T> newNode = new(T, 0);
            Head = newNode;
            Cursor = newNode;
        }
        else
        {
            Node<T> newNode = new(T, Cursor.Index+1)
            Cursor.Next = newNode;
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


    
    public class Node<TNodeData>
    //where T : notnull, new()

    {

        
        public Node<TNodeData> Next { get; private set; }
        public int Index { get; set; }

        public Node(TNodeData t, int index)
        { // type of Node is always T, but once it's in node, we call it TNodeData
            
            NodeType = t;

        }

        [DisallowNull]
        public T NodeType { get; set; }

        //public void SetNext([DisallowNull] TNodeData newNodeData)
        //{
        //    Node<TNodeData> newNode = new()


        //    Next = newNode;// I check for null just above this??
        //    newNode.Next = newNode;

        //}

        public override string ToString()
        {
            return "Node of type " + typeof(T); //+ " with index: " + Index;
        }

    }


}
