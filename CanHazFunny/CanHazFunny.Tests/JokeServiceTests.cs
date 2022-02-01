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
        public void Contains_ChuckNorris_True()
        {
            string test = "this joke has Chuck Norris in it";
            //string testLowerCase = "this joke has chuck norris in it";
            //string testSeparated = "this joke has Chuck and Norris in it";
            Assert.IsTrue(test.Contains("Chuck Norris"));
            //Assert.IsTrue(testLowerCase.Contains("Chuck Norris"));
            //Assert.IsTrue(testSeparated.Contains("Chuck Norris"));
        }
       

    }



}

