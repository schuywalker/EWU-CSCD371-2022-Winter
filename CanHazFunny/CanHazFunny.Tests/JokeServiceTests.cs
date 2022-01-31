using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanHazFunny.Tests
{
    internal class JokeServiceTests
    {
        public void GetJoke_ReturnsNonNullString_Success()
        {
            JokeService jokeService = new JokeService();
            string joke = jokeService.GetJoke();
            Assert.IsNotNull(joke);
        }
    }
}
