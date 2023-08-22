using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public static class Verify
    {
        public static char UserInput()
        {
            Console.Write("\n\nEnter a letter: ");
            bool check = char.TryParse(Console.ReadLine(), out char temp);

            while (!check || !Char.IsLetter(temp))
            {
                Console.Write("Enter a valid character: ");
                check = char.TryParse(Console.ReadLine(), out temp);
            }

            temp = Char.ToLower(temp);

            //check if letter has already been guessed
            for (int i = 0; i < Guess.GuessedLetters.Count; i++)
            {
                while (Guess.GuessedLetters[i] == temp)
                {
                    Console.WriteLine("Letter already guessed! ");
                    Console.Write("Enter a different letter: ");
                    check = char.TryParse(Console.ReadLine(), out temp);

                    while (!check || !Char.IsLetter(temp))
                    {
                        Console.Write("Enter a valid character: ");
                        check = char.TryParse(Console.ReadLine(), out temp);

                    }
                    i = 0;
                }

            }

            temp = Char.ToLower(temp);
            Guess.guess = temp;
            return Guess.guess;
        }
        public static void Underscores()
        {
            foreach (char c in Words.GetKeyWord())
            {
                Design.Underscores = "_";
            }
            // Display the results
            Design.Results();
        }
        public static void GameResults()
        {
            if (Guess.GuessedIncorrectly < 6)
                Console.WriteLine("\n\n\t\t    YOU WIN!");
            else if (Design.Underscores.Contains("_"))
            {
                Console.WriteLine("\n\n\t\t    YOU LOSE!");
                Console.WriteLine($"\nTHe word was {Words.GetKeyWord()}");
            }
        }
        public static void Logic()
        {
            while (Guess.GuessedIncorrectly < 6 && Design.Underscores.Contains("_"))
            {
                int guessedCorrectly = 0;
                // verify character guessed
                Verify.UserInput();

                // goes through each character to check if guess is equal to the letter in the word
                for (int i = 0; i < Words.GetKeyWord().Length; i++)
                {

                    if (Words.GetKeyWord()[i] == Guess.guess)
                    {
                        Design.Underscores = Design.RemoveChar(Design.Underscores, i);
                        Design.Underscores = Design.Underscores.Insert(i, Guess.guess.ToString());
                        guessedCorrectly++;
                        Guess.GuessedLetters.Add(Guess.guess);
                        Design.Results();
                    }
                    else if (guessedCorrectly == 0 && i == Words.GetKeyWord().Length - 1)
                    {
                        Guess.GuessedIncorrectly = 1;
                        Guess.GuessedLetters.Add(Guess.guess);
                        Guess.GuessedIncorrectLetters.Add(Guess.guess);
                        Design.HangmanAddBodyParts();
                    }

                }
            }
        }

    }
}
