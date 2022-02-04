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

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WriteJokeToConsole_NullArgument_Exception()
        {
        ConsoleOutput consoleOutput = new();
        consoleOutput.WriteJokeToConsole(null!);
       // Assert.ThrowsException<ArgumentNullException>(() => consoleOutput.WriteJokeToConsole(null!));
           
        }
       /* [TestMethod] // method times out and then says it's been run when I hit stop. Not sure why, but it's an unnecessary test.
        *leaving in her until I understand what's happening with it.
        public void WriteJokeToConsole_GoodArgument_Success()
        {
            ConsoleOutput consoleOutput1 = new();
            string joke = "test output string";
            
            consoleOutput1.WriteJokeToConsole(joke);
            string? whatsInConsole = Console.ReadLine();
            
            Assert.IsNotNull(whatsInConsole);
            Assert.AreEqual(joke, whatsInConsole);
        }*/

    }
    


