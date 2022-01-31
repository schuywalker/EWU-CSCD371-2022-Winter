using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    internal class Jester 
    {
        private readonly IJokeService _jokeService;
        private readonly IConsoleOutput _consoleOutput;
        public bool returningChuckNorrisJoke { get; set; }

        public Jester(IConsoleOutput IconsoleOutput, IJokeService IjokeService)
        {
            if (IconsoleOutput is null || IjokeService is null)
            {
                throw new ArgumentNullException("an interface arg was null");
            }
            _jokeService = IjokeService;
            _consoleOutput = IconsoleOutput;
        }
       
        
        public void TellJoke()
        {
            string joke = _jokeService.GetJoke();
            while (_jokeService.returningChuckNorrisJoke == true)
            {
                _jokeService.returningChuckNorrisJoke = false;
                joke = _jokeService.GetJoke();

            }
        }
    }
}
