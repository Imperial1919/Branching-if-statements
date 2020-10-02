using System;

namespace Branching_With_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter any number:");
            double num = Convert.ToDouble(Console.ReadLine());
      

        
                 if (num == 5)
                {
                    Console.WriteLine("Perfect answer!");
                }

                 else if (num > 5)
            {
                Console.WriteLine("This value is too large, try again");
               
            }

                 else if (num < 5)
            {
                Console.WriteLine("That is too small a value, guess again please.");
               
            }

            Console.Write("thank You very much, now please type in a single letter:");
            char letter = Convert.ToChar(Console.ReadLine());

            if ((letter == 'C') || (letter == 'c') ) {
                Console.WriteLine("Huh.. Good Guess.");
            }

            else
            {
                Console.WriteLine("Incorrect.");
            }

            Console.ReadKey();

        }
    }
}
