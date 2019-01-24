//Author: Joshua Cordle
//Date: 1/24/2019
//Comments: Preform a while loop and read the value of users input in the loop

using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter a number
            Console.WriteLine("Please enter a number between 1 and 100");

            //Use try-catch method to determine proper data type is entered
            try
            {
                //read the user's input 
                string input = Console.ReadLine();

                //name the variable 
                int number = int.Parse(input);

                //read the number entered by the user and the amount of times the loop will itereate
                Console.WriteLine("You have entered " + number.ToString());

                //Write the while loop
                while (number > 0)
                {
                    Console.WriteLine("This is the current integer value in the loop: " + number.ToString());
                    number--;
                }
                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please only enter a number...");
                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey(true);
            }
        }
    }
}

