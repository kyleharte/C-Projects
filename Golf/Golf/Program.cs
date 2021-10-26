using System;

namespace Golf
{
    class Program
    {
        /*
         * Array which holds the data for each hole
         */
        static readonly int[] hole = { 4, 3, 5, 3, 4, 5, 3, 3, 3, 4, 3, 4, 5, 3, 3, 4, 5, 3};
        
        static void printArray()
        {
            Console.WriteLine("Par of each hole is as follows");
            foreach (int value in hole) {
                Console.WriteLine(value);
            }
        }
        static String playerInput(String msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }



        /*
         * Enumeraters that allows you to simply select the type of the score
         */
        enum Par
        {
            ALBATROSS = -3,
            EAGLE = -2,
            BIRDIE = -1,
            Par = 0,
            BOGEY = 1,
            D_BOGEY = 2,
            T_BOGEY = 3
        }

        /*
         * Menu Method
         * Method that produces a menu for the user
         */
        static int menu()
        {
            try
            {
                int input = Convert.ToInt16(playerInput("Please enter a hole number"));
                return input;
            }
            catch
            {
                Console.WriteLine("That is not a number");
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int hole_num = menu();
            int shots =  Convert.ToInt16(playerInput("Please enter the number of shots of hole " + hole_num));
            Par score = (Par) shots - hole[hole_num - 1];
            Console.WriteLine((int)score);
            switch (score)
            {
                case Par.ALBATROSS:
                    Console.WriteLine("Albatross");
                    break;
                case Par.EAGLE:
                    Console.WriteLine("Eagle");
                    break;
                case Par.BIRDIE:
                    Console.WriteLine("Birdie");
                    break;
                case Par.Par:
                    Console.WriteLine("Par");
                    break;
                case Par.BOGEY:
                    Console.WriteLine("Bogey");
                    break;
                case Par.D_BOGEY:
                    Console.WriteLine("Double Bogey");
                    break;
                case Par.T_BOGEY:
                    Console.WriteLine("Triple Bogey");
                    break;

            }

        }
    }

}
