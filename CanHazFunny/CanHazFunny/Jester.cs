using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny;

public class Jester
{

    private IJokeService JokeService { get; set; } // set in constructor
    private IConsoleOutput ConsoleOutput { get; set; }



    public Jester(IJokeService IjokeService, IConsoleOutput IconsoleOutput)
    {
        if (IconsoleOutput is null || IjokeService is null)
        {
            throw new ArgumentNullException("an arg was null");
        }
        JokeService = IjokeService;
        ConsoleOutput = IconsoleOutput;
    }



    public void TellJoke()
    {
        string joke = JokeService.GetJoke();
        //int failSafeCounter = 0;
        while (joke.Contains("Chuck Norris"))
        {
            joke = JokeService.GetJoke();

            //failSafeCounter++;
            //if (failSafeCounter > 20)
            //{
                //Console.WriteLine("Either 20 chuck norris jokes in a row or there is a bug");
              //  break;
            //}
        }
        ConsoleOutput.WriteJokeToConsole(joke);
    }
}

