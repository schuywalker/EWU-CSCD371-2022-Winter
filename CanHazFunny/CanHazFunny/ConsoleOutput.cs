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
            Console.WriteLine(joke);
        }
    }
}
