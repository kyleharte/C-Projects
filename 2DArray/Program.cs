using System;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] capitals = new string[2, 5]
            {
                {"Ireland", "Germany", "Canada", "USA", "UK" },
                {"Dublin", "Berlin", "Toronto", "Washington D.C", "London" }
            };
                for (int i = 0; i < 5; i++) {
                String city = capitals[0, i];
                String answer = capitals[1, i];

                Console.WriteLine("What is the capital city of " + city);
                String useranswer = Console.ReadLine();
                if(useranswer.ToLower() == answer.ToLower())
                {
                    Console.Write("You are correct. \n");
                } else
                {
                    Console.WriteLine("Wrong! The answer is " + answer);
                }
                }

    
        
        }
    }
}
