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

        [TestMethod]
        public void Node_NullArg_Exception()
        {
            Node<string> test;
            Assert.ThrowsException<ArgumentNullException>(() => test = new(null!));
        }


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

        [TestMethod]
        public void Exists_ValuePresentAndSizeGreaterThan1_Sucess()
        {
            Node<string> testNode = new("first node string value");
            testNode.Append("2nd node 42");
            testNode.Next.Append("3 is magic");

            Assert.IsTrue(testNode.Exists("3 is magic"));
        }
        [TestMethod]
        public void Exists_ValueNotPresentAndSizeGreaterThan1_Sucess()
        {
            Node<string> testNode = new("first node string value");
            testNode.Append("2nd node 42");
            testNode.Next.Append("3 is magic");

            Assert.IsFalse(testNode.Exists("strawberry fields 4ever"));
        }
        [TestMethod]
        public void Exists_ValuePresentAndSizeIs1_Sucess()
        {
            Node<int> testNode = new(777);
            

            Assert.IsTrue(testNode.Exists(777));
        }
        [TestMethod]
        public void Exists_ValueNotPresentAndSizeIs1_Sucess()
        {
            Node<int> testNode = new(777);

            Assert.IsFalse(testNode.Exists(42));
        }

    }

}
