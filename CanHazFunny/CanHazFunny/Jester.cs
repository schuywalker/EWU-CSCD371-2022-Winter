using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    internal class Jester // get a joke from joke service. make sure it doesnt have chuck. output it.
    {   // jester is driver, Idrivable, Idestination. driver can drive a audi or nissan, so long as then implement IDrivable.
        
        private IJokeService? jokeService { get; } // set in constructor
        private IConsoleOutput? consoleOutput;

        public Jester(IJokeService IjokeService, IConsoleOutput IconsoleOutput)
        {
            if (IconsoleOutput is null || IjokeService is null)
            {
                throw new ArgumentNullException("an arg was null");
            }
            jokeService = IjokeService;
            consoleOutput = IconsoleOutput;
        }
       
       // jester filters
       // interface should do what jokeService did by default
       // liskov - base class extends iserviceable (jokeService) so jokeService can be used as an IServicable
       
        public void TellJoke()
        {
            string joke = jokeService!.GetJoke(); // ! because TellJoke cant be called without instance, and constructor checks for null
            int failSafeCounter = 0;
            while (joke.Contains("Chuck Norris"))
            {
                joke = jokeService.GetJoke();
                
                failSafeCounter++;
                if (failSafeCounter > 20)
                {
                    Console.WriteLine("Either 20 chuck norris jokes in a row or there is a bug");
                    break;
                }
            }
            consoleOutput!.writeJokeToConsole(joke); // same as above - ! because TellJoke cant be called without instance, and constructor checks for null
        }
    }
}
