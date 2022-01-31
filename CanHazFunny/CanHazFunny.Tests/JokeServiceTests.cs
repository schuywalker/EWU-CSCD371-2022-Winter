using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JokeServiceTests
    {
        
        [TestMethod]
        public void GetJoke_ReturnsNonNullString_Success()
        {
            JokeService jokeService = new();
            string joke = jokeService.GetJoke();
            Assert.IsNotNull(joke);
        }
        [TestMethod]
        public void GetJoke()
        {

        }
        // test chuck norris boolean changed

        //test chuck norris not contained in joke

        // test console

    }



}

