using System;
/*
 * Create a new project called NumberRange  

The code should initially ask the end user to input an integer.  

This integer should be saved as a variable such as myInt. 

 You should then write an if else statement to display a message according to  

 

Whether the number is less or equal to zero 

Whether the number is in the range 1 to 10 

Whether the number is in the range 11 to 20 

Whether the number is in the range 21 to 30 

Otherwise display a message stating that the number is over 30 
*/
namespace NumberRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer");
            int myInt = Convert.ToInt32(Console.ReadLine());

            if (myInt <= 0)
            {
                Console.WriteLine("Integer is less than or equal to 0");
            }
            else if (myInt <= 10 && myInt >= 1)
            {
                Console.WriteLine("Integer is less than or equal to 10 and greater to or equal to 1");
            } else if(myInt <= 20 && myInt > 10)
            {
                Console.WriteLine("Integer is less than or equal to 20 and greater than 10");
            } else  if(myInt <= 30 && myInt > 20)
            {
                Console.WriteLine("Integer is less than or equal to 30 and greater than 20");
            } else { Console.WriteLine("Integer is greater than 30"); }
        }
    }
}
