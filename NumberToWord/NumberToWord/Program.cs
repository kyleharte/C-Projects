using System;

namespace NumberToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("One");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Two");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Three");

            }
            else if (userInput == 4)
            {
                Console.WriteLine("Four");
            }
            else if (userInput == 5)
            {
                Console.WriteLine("Five");
            }
            else if (userInput == 6)
            {
                Console.WriteLine("Six");
            }
            else if (userInput == 7)
            {
                Console.WriteLine("Seven");
            } else if (userInput == 8)
            {
                Console.WriteLine("Eight");
            } else if(userInput == 9)
            {
                Console.WriteLine("Nine");
            } else
            {
                Console.WriteLine("Error");
            }

        }
    }
}