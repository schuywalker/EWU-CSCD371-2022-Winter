using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework.Tests
{
    [TestClass]
    public class MyTestClass
    {
        
        [TestMethod]
        public void Node_DataTypeAsExcepted_Success()
        {
            CircularlyLinkedList<string> cll = new();
            cll.Append(String);
        }
        public void NodeConstructor_NextSetToSelf_Success()
        {

        }
    }
    
}
