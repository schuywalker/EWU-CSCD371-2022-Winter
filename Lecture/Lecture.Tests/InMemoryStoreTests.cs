using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Tests
{
    internal class Class
    {
        [TestMethod]
        
        public void Save_GivenMockSavable_Success()
            {
            InMemoryStore? store = new();
            MockThing mockThing = new("Inigo Montoya");
            store.Save(mockThing);
            Assert.AreEqual<string?>("Inigo Montoya", (store.Item as mockThing)?.Name);
            Assert.AreEqual<string?>("Inigo Montoya", (store.Item?.ToText());
            Assert.AreEqual<ISavable?>(mockThing, store.Item); // best way
            }
        
    }
}
