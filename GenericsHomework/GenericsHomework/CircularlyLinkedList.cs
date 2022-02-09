//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Diagnostics.CodeAnalysis;

//namespace GenericsHomework;

//public class CircularlyLinkedList<T>
//    where T : notnull

//{

//    public Node<T>? Tail { get; set; }
//    public Node<T>? Head { get; set; }
    




//    public void Append([DisallowNull] T t)
//    {
//        if (Head is null || Tail is null)
//        {

//            Node<T> newNode = new(t);
//            Head = newNode;
//            Tail = newNode;
//        }
//        else
//        {
//            Node<T> temp = new(t, Tail);
//        }

//    }

//    public void Clear(Node<T> node)
//    {
//        if (node is null) throw new ArgumentNullException("Argument cannot be null");
//        if (Head == node && Tail == node) return; // CLL size == 1: do nothing
//        else 
//        {
//            Head = null;
//            Tail = null;
//            Type type = typeof(T) ?? throw new InvalidDataException("Type of node cannot be null");
//            Append(type);
//        }
//        // size > 1, head == node
//        //size > 1, tail == node
//        // size > 1, node in middle of list
//    }
//    public bool Exists(T Value)
//    {
//        return false;
//    }


//}
//    //public T ReturnType(int index)
//    //{
        
//    //    Node<T> CursorTemp = Tail!;//about to be null checked
//    //    if (Tail is null || Head is null) throw new InvalidOperationException();
//    //    else if (index == Tail.Index)
//    //    {
//    //        return Tail.NodeType;
//    //    }

//    //    else if (CursorTemp.Index < index)
//    //    {

//    //        while (CursorTemp.Index < index)
//    //        {
//    //            CursorTemp = CursorTemp.Next;
//    //        }
//    //        return CursorTemp.NodeType;
//    //    }
//    //    else
//    //    {
//    //        CursorTemp = Head;
//    //        while (CursorTemp.Index < index)
//    //        {
//    //            CursorTemp = CursorTemp.Next;
//    //        }
//    //        return CursorTemp.NodeType;
//    //    }
//    //}





//// interesting interview question:
//// im writing method, you pass me node, return whether the node in question eventually ends in null or circles back on itself