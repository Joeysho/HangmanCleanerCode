using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public static class Design
    {
        private static string _template = string.Format(@"              _____________
              |           |
              |           |
                          |
                          |
                          |
                          |
                          |
               ___________|_______");
        private static string _underscores = "";

        public static string Template { get { return _template; } set { _template = value; } }
        public static string  Underscores
        {
            get 
            {
                return _underscores; 
            } set
            {
                if (value == "_")
                {
                    _underscores += value;
                }
                else
                {
                    _underscores = value;
                }
            } 
        }
        public static void Results()
        {
            Console.Clear();

            Console.Write(Template + "\t");

            foreach (char c in _underscores)
            {
                Console.Write(c + " ");
            }
            Words.ListOfUsedChars();
        }

        public static void HangmanAddBodyParts()
        {
            Console.Clear();

            switch (Guess.GuessedIncorrectly)
            {
                case 1:
                    AddBodyPart.Head();
                    break;
                case 2:
                    AddBodyPart.Body();
                    break;
                case 3:
                    AddBodyPart.LeftArm();
                    break;
                case 4:
                    AddBodyPart.RightArm();
                    break;
                case 5:
                    AddBodyPart.LeftLeg();
                    break;
                case 6:
                    AddBodyPart.RightLeg();
                    break;

            }

            foreach (char c in Underscores)
            {
                Console.Write(c + " ");
            }
            Words.ListOfUsedChars();
        }
        public static string RemoveChar(string str, int i)
        {
            return str.Remove(i, 1);
        }
    }
}
