using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class ConsoleOutput : IConsoleOutput
    {
        public void writeJokeToConsole(string joke)
        {
            if (joke is null)
            {
                throw new ArgumentNullException("joke was null in ConsoleOutput.writeJokeToConsole");
            }
            Console.WriteLine(joke);
        }
    }
}
