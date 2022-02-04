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



    public string TellJoke()
    {
        string joke = JokeService.GetJoke();
     
        while (
            joke.ToLower().Contains("chuck norris") || 
            joke.ToLower().Contains("chuck") || 
            joke.ToLower().Contains("norris")
            )
        {
            joke = JokeService.GetJoke();
        }
        ConsoleOutput.WriteJokeToConsole(joke);
        return joke;
    }
    
}

