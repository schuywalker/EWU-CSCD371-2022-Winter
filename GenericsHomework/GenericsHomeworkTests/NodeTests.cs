using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace GenericsHomework.Tests
{
    [TestClass]
    public class MyTestClass
    {

        //[TestMethod]
        //[ExpectedException()]
        //public void Node_NullArg_Exception()
        //{
        //    Node<string> test = new(null!);
        //}


        [TestMethod]
        public void Node_SingleNodePointsToSelf_Success()
        {
            Node<string> testNode = new("test string");
            Assert.AreEqual<string>("test string", testNode.Next.Value);
        }
        [TestMethod]
        public void Append_ListIsCircular_Success()
        {
            Node<string> testNode = new("first node string value");
            testNode.Append("2nd node 42");
            testNode.Next.Append("3 is magic");

            Node<string> Cursor = testNode.Next;
            Assert.AreEqual<string>("2nd node 42", Cursor.Value);

            Cursor = Cursor.Next;
            Assert.AreEqual<string>("3 is magic", Cursor.Value);

            Cursor = Cursor.Next;
            Assert.AreEqual<string>("first node string value", Cursor.Value);

            Assert.IsTrue(Cursor == testNode);

        }
        [TestMethod]
        public void Clear_WorksOnFirstNode_Success()
        {
            Node<string> testNode = new("first node string value");
            testNode.Append("2nd node 42");
            testNode.Next.Append("3 is magic");

            testNode.Clear();
            Assert.AreEqual<string>("first node string value", testNode.Value);
            Assert.AreEqual<string>("first node string value", testNode.Next.Value);
        }
    }

}
