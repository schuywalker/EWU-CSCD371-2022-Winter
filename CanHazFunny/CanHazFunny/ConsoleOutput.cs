using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class ConsoleOutput : IConsoleOutput
    {
        public void WriteJokeToConsole(string joke)
        {
            if (joke is null)
            {
                throw new ArgumentNullException("joke should not be null");
            }
            Console.WriteLine(joke);
        }
    }
}
