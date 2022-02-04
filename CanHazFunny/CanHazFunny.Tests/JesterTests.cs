using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// naming of tests: name of method being tested, scenario, expected behavior
namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
       

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Jester_NullArgJokeService_Exception()
        {
           
            ConsoleOutput consoleOutput = new();
            JokeService jokeService = null!;

            Jester Jester = new(jokeService,consoleOutput);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Jester_NullArgConsoleOutput_Exception()
        {

            ConsoleOutput consoleOutput = null!;
            JokeService jokeService = new();

            Jester Jester = new(jokeService, consoleOutput);

        }
        [TestMethod]
        public void Test_NotUsedYet()
        {
            JokeService jokeService = new();
            ConsoleOutput consoleOutput = new();
            Jester Jester = new(jokeService, consoleOutput);
            Assert.IsFalse(Jester.TellJoke().ToLower().Contains("chuck norris"));
        }
       
    }
}
