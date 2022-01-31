using System.Net.Http;
using System;

namespace CanHazFunny
{
    public class JokeService : IJokeService
    {
        private HttpClient HttpClient { get; } = new();
        public bool returningChuckNorrisJoke { get; set; }

        

        public string GetJoke()
        {
            string joke = HttpClient.GetStringAsync("https://geek-jokes.sameerkumar.website/api").Result;
            //if (joke.Contains("Chuck Norris"))
            //{
             //   returningChuckNorrisJoke = true;
            //}
            return joke;
        }

        
    }
}
