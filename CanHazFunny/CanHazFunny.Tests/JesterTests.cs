using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// naming of tests: name of method being tested, scenario, expected behavior
namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        Jester? jester;

        [TestMethod]
        public void Jester_NullArguments_Exception()
        {
            Jester jester;
            ConsoleOutput consoleOutput = new();
            JokeService jokeService = null!;

            Assert.ThrowsException<ArgumentNullException>(() => jester = new(jokeService,consoleOutput));
        }
        [TestMethod]
        public void MyTestMethod()
        {
            JokeService jokeService = new();
            ConsoleOutput consoleOutput = new();
            jester = new(jokeService, consoleOutput);
        }
        /*[TestMethod]
        public void Jester_()
        {
            Jester mock = new();
            Assert.IsNotNull(mock)

        }*/
    }
}
