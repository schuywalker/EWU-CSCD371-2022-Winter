using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    internal class ConsoleOutput : IConsoleOutput
    {
        public void writeJokeToConsole(string joke)
        {
            Console.WriteLine(joke);
        }
    }
}
