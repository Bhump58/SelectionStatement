using Microsoft.VisualBasic.CompilerServices;
using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
            var isCorrect = false;
            
            Console.WriteLine("Let's play a number guessing game!!");
            Console.WriteLine("Let's pick a number between 1 and 10");
            
           
            
            while(!isCorrect) {
                Console.WriteLine("Take a guess");
                var guess = int.Parse(Console.ReadLine());

                if(guess > 10)
                {
                    Console.WriteLine("This number isn't between");
                } else
                {
                    if (guess < favNumber)
                    {
                        Console.WriteLine("Number is too low");
                    }
                    else if (guess > favNumber)
                    {
                        Console.WriteLine("Number is too high");
                    }
                    else
                    {
                        Console.WriteLine("You got it right");
                        isCorrect = true;
                    }
                }
            }
           
        }
    }
}
