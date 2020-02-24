using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DesignPatterns.Patterns.SingletonPattern
{
    public class Singleton
    {
        private static Singleton FirstInstance = null;

        private IList<string> _scrabbleLetters = new List<string>(){
            "a", "a", "a", "a", "a", "a", "a", "a", "a", "b", "b", "b", "b", "b", "b", "b", "b", "b",
            "c", "c", "c", "c", "c", "c", "c", "c", "c", "d", "d", "d", "d", "d", "d", "d", "d", "d",
            "e", "e", "e", "e", "e", "e", "e", "e", "e", "f", "f", "f", "f", "f", "f", "f", "f", "f",
            "g", "g", "g", "g", "g", "g", "g", "g", "g", "h", "h", "h", "h", "h", "h", "h", "h", "h",
            "i", "i", "i", "i", "i", "i", "i", "i", "i", "j", "j", "j", "j", "j", "j", "j", "j", "j",
            "k", "k", "k", "k", "k", "k", "k", "k", "k", "l", "l", "l", "l", "l", "l", "l", "l", "l",
            "m", "m", "m", "m", "m", "m", "m", "m", "m", "n", "n", "n", "n", "n", "n", "n", "n", "n",
            "o", "o", "o", "o", "o", "o", "o", "o", "o", "p", "p", "p", "p", "p", "p", "p", "p", "p",
            "q", "q", "q", "q", "q", "q", "q", "q", "q", "r", "r", "r", "r", "r", "r", "r", "r", "r",
            "s", "s", "s", "s", "s", "s", "s", "s", "s", "t", "t", "t", "t", "t", "t", "t", "t", "t",
            "v", "v", "v", "v", "v", "v", "v", "v", "v", "u", "u", "u", "u", "u", "u", "u", "u", "u",
            "w", "w", "w", "w", "w", "w", "w", "w", "w", "x", "x", "x", "x", "x", "x", "x", "x", "x",
            "y", "y", "y", "y", "y", "y", "y", "y", "y", "z", "z", "z", "z", "z", "z", "z", "z", "z"
        };

        static bool _firstThread = true;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (FirstInstance == null)
            {
                if (_firstThread) {
                    _firstThread = false;

                    Thread.Sleep(1000);
                }
                // LAZY INSTANTIATION
                FirstInstance = new Singleton();

                //https://stackoverflow.com/questions/273313/randomize-a-listt
                Random random = new Random();
                FirstInstance._scrabbleLetters =
                    FirstInstance._scrabbleLetters
                        .OrderBy(x => random.Next())
                        .ToList();
            }

            return FirstInstance;
        }

        public IList<string> GetLetterList()
        {
            return FirstInstance._scrabbleLetters;
        }

        public IList<string> GetTiles(int howManyTiles)
        {
            IList<string> tilesToSend = new List<string>();

            for (int i = 1; i <= howManyTiles; i++)
            {
                tilesToSend.Add(FirstInstance._scrabbleLetters[0]);
                FirstInstance._scrabbleLetters.RemoveAt(0);
            }

            return tilesToSend;
        }
    }
}
