using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public static class AddBodyPart
    {
        public static void Head()
        {
            Design.Template = @"              _____________
              |           |
              |           |
              O           |
                          |
                          |
                          |
                          |
               ___________|_______";
            Console.Write(Design.Template + "\t");
        }
        public static void Body()
        {
            Design.Template = @"              _____________
              |           |
              |           |
              O           |
              |           |
                          |
                          |
                          |
               ___________|_______";
            Console.Write(Design.Template + "\t");
        }
        public static void LeftArm()
        {
            Design.Template = @"              _____________
              |           |
              |           |
              O           |
             \|           |
                          |
                          |
                          |
               ___________|_______";
            Console.Write(Design.Template + "\t");
        }
        public static void RightArm()
        {
            Design.Template = @"              _____________
              |           |
              |           |
              O           |
             \|/          |
                          |
                          |
                          |
               ___________|_______";
            Console.Write(Design.Template + "\t");
        }
        public static void LeftLeg()
        {
            Design.Template = @"              _____________
              |           |
              |           |
              O           |
             \|/          |
             /            |
                          |
                          |
               ___________|_______";
            Console.Write(Design.Template + "\t");
        }
        public static void RightLeg()
        {
            Design.Template = @"              _____________
              |           |
              |           |
              O           |
             \|/          |
             / \          |
                          |
                          |
               ___________|_______";
            Console.Write(Design.Template + "\t");
        }

    }
}
