using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public static class Guess
    {
        private static char _guess;
        private static int _guessedIncorrectly = 0;
        private static List<char> _guessedLetters = new List<char>();
        private static List<char> _guessedIncorrectList = new List<char>();

        public static char guess { get { return _guess; } set { _guess = value; } }
        public static int GuessedIncorrectly { get { return _guessedIncorrectly; } 
            set { _guessedIncorrectly += value; } }
        public static List<char> GuessedLetters { get { return _guessedLetters; }}
        public static List<char> GuessedIncorrectLetters { get { return _guessedIncorrectList; } }
    }
}
