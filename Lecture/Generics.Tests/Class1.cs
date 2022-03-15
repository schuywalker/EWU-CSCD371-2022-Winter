using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Generics.Tests;
public class Container<T>
   where T : notnull
{
    private T? _Value;
    public T Value
    {
        get
        {
            return _Value!;
        }
        set
        {
            
            if (!Value.Equals(value))
            {
                _Value = value??throw new ArgumentNullException(nameof(value));
            }
        }
    }

#pragma warning disable IDE0051 // Remove unused private members
    // Potentially used to cache the count.
    private Container<T>? Root { get; set; }
#pragma warning restore IDE0051 // Remove unused private members

    Container(T value)
    {
        Value = value;
    }
    public class NodeCollectionFactory<TValue> where TValue : notnull
    {
        public Container<TValue> CreateNewNodeCollection(TValue item)
        {
            return new Container<TValue>(item);
        }
    }
}

[TestClass]
public class MoreGenericStuff
{

    [TestMethod]
    public void MyTestMethod()
    {
        Container<int>? container = null;
        if(container is null)
        {

        }
    }
}
