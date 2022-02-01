using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny;

    public class Jester 
    {   
        
        private IJokeService? jokeService { get; set; } // set in constructor
        private IConsoleOutput? consoleOutput { get; set; }

        public Jester() // for mocks...
        {

        }

         public Jester(IJokeService IjokeService, IConsoleOutput IconsoleOutput)
         {
            if (IconsoleOutput is null || IjokeService is null)
            {
                throw new ArgumentNullException("an arg was null");
            }
            jokeService = IjokeService;
            consoleOutput = IconsoleOutput;
         }
       
       
       
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
            consoleOutput!.WriteJokeToConsole(joke); // same as above - ! because TellJoke cant be called without instance, and constructor checks for null
        }
    }

