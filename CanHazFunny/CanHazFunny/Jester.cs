using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    internal class Jester 
    {
        private JokeService muse;
        private ConsoleOutput consoleOutput = new();


        public Jester()
        {
            muse = new();
        }
       
        
        public void tellJoke()
        {
            string joke = muse.GetJoke();
            while (muse.returningChuckNorrisJoke == true)
            {
                muse.returningChuckNorrisJoke = false;
                joke = muse.GetJoke();

            }
        }
    }
}
