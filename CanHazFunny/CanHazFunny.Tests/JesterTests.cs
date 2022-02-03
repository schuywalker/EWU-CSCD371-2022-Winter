using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// naming of tests: name of method being tested, scenario, expected behavior
namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
       // Jester? jester;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Jester_NullArgJokeService_Exception()
        {
           
            ConsoleOutput consoleOutput = new();
            JokeService jokeService = null!;

            Jester jester = new(jokeService,consoleOutput);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Jester_NullArgConsoleOutput_Exception()
        {

            ConsoleOutput consoleOutput = null!;
            JokeService jokeService = new();

            Jester jester = new(jokeService, consoleOutput);

        }
        [TestMethod]
        public void Test_NotUsedYet()
        {
            JokeService jokeService = new();
            ConsoleOutput consoleOutput = new();
            Jester jester = new(jokeService, consoleOutput);
        
        
        }
       
    }
}
