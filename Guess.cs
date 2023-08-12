using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Guess
    {
        private static char guess;
        private static int guessedIncorrectly = 0;
        private static List<char> guessedLetters = new List<char>();
        private static List<char> guessedIncorrectList = new List<char>();

        public static char GetGuess()
        {
            return guess;
        }
        public static void SetGuess(char temp)
        {
            guess = temp;
        }
        public static int GetIncorrectGuess()
        {
            return guessedIncorrectly;
        }
        public static void SetIncorrectGuess(int guessedIncorrectly)
        {
            Guess.guessedIncorrectly += guessedIncorrectly;
        }
        public static List<char> GetGuessedLetters()
        {
            return guessedLetters;
        }
        public static List<char> GetIncorrectGuessList()
        {
            return guessedIncorrectList;
        }
    }
}
