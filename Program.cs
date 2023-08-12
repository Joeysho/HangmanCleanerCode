using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Verify.Underscores();
            
            Verify.Logic();

            Verify.GameResults();

            Console.ReadLine();
        }

    }
}
