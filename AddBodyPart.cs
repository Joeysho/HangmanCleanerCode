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
            Design.SetTemplate(@"              _____________
              |           |
              |           |
              O           |
                          |
                          |
                          |
                          |
               ___________|_______");
            Console.Write(Design.GetTemplate() + "\t");
        }
        public static void Body()
        {
            Design.SetTemplate(@"              _____________
              |           |
              |           |
              O           |
              |           |
                          |
                          |
                          |
               ___________|_______");
            Console.Write(Design.GetTemplate() + "\t");
        }
        public static void LeftArm()
        {
            Design.SetTemplate(@"              _____________
              |           |
              |           |
              O           |
             \|           |
                          |
                          |
                          |
               ___________|_______");
            Console.Write(Design.GetTemplate() + "\t");
        }
        public static void RightArm()
        {
            Design.SetTemplate(@"              _____________
              |           |
              |           |
              O           |
             \|/          |
                          |
                          |
                          |
               ___________|_______");
            Console.Write(Design.GetTemplate() + "\t");
        }
        public static void LeftLeg()
        {
            Design.SetTemplate(@"              _____________
              |           |
              |           |
              O           |
             \|/          |
             /            |
                          |
                          |
               ___________|_______");
            Console.Write(Design.GetTemplate() + "\t");
        }
        public static void RightLeg()
        {
            Design.SetTemplate(@"              _____________
              |           |
              |           |
              O           |
             \|/          |
             / \          |
                          |
                          |
               ___________|_______");
            Console.Write(Design.GetTemplate() + "\t");
        }

    }
}
