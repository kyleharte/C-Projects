using System;
/*
 * Step 1: Create a new project(C# Console Application) and name it Task6 

As in task four a program is required to print "ONE", "TWO", ... , "NINE” if the integer entered is between 1 and 9. If anything other than 1 to 9 is entered then an error message is displayed. However this time you will use a Switch Case statement 

Step 2: In the Program.cs write the code shown below and complete the rest of the case statements up to 9.  

 

Step 3: Save the class (CTRL +Shift+ S) and run the program. Expected output is shown below.  

 

 

Step 4:  

You should aim to test your program again with the following:  

1. All nine integers between 1 and 9.  

2. A few other integers outside this range i.e. 10 and 100.  
*/
namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 9");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1: Console.WriteLine("One");break;
                case 2: Console.WriteLine("Two");break;
                case 3: Console.WriteLine("Three");break;
                case 4: Console.WriteLine("Four");break;
                case 5: Console.WriteLine("Five");break;
                case 6: Console.WriteLine("Six");break;
                case 7: Console.WriteLine("Seven");break;
                case 8: Console.WriteLine("Eight");break;
                case 9: Console.WriteLine("Nine");break;
                default: Console.WriteLine("Error");break;

            }
        }
    }
}
