using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanHazFunny.Tests;

    [TestClass]
    public class ConsoleOutputTests
    {
     /*   
        [TestInitialize]
        public void testInit()
        {
            ConsoleOutput consoleOutput = new();
        }
        [TestCleanup]
        public void testCleanUp()
    {
            consoleOutput = null;
    }
        
        */
        [TestMethod]
        public void WriteJokeToConsole_NullArgument_Exception()
        {
        ConsoleOutput consoleOutput = new();
        Assert.ThrowsException<ArgumentNullException>(() => consoleOutput.WriteJokeToConsole(null!));
           
        }
        [TestMethod]
        public void WriteJokeToConsole_GoodArgument_Success()
        {
            ConsoleOutput consoleOutput1 = new();
            string joke = "test output string";
            
            consoleOutput1.WriteJokeToConsole(joke);
            string? whatsInConsole = Console.ReadLine();
            
            Assert.IsNotNull(whatsInConsole);
            Assert.AreEqual(joke, whatsInConsole);
        }

    }
    


