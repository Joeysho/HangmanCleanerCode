using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public static class Design
    {
        private static string template = string.Format(@"              _____________
              |           |
              |           |
                          |
                          |
                          |
                          |
                          |
               ___________|_______");
        private static string underscores = "";
        public static string GetTemplate()
        {
            return template;
        }
        public static void SetTemplate(string template)
        {
            Design.template = template;
        }
        public static string GetUnderscores()
        {
            return underscores;
        }
        public static void SetUnderScores(string underscore)
        {
            if (underscore == "_")
            {
                underscores += underscore;
            }
            else
            {
                underscores = underscore;
            }
        }
        public static void Results()
        {
            Console.Clear();

            Console.Write(GetTemplate() + "\t");

            foreach (char c in underscores)
            {
                Console.Write(c + " ");
            }
            Words.ListOfUsedChars();
        }

        public static void HangmanAddBodyParts()
        {
            Console.Clear();

            switch (Guess.GetIncorrectGuess())
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

            foreach (char c in Design.GetUnderscores())
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
