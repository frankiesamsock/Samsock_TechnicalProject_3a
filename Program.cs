/*
 Author: Frank Samsock
 Date: 9/22/2020
 Description: This is a console program that demonstrates a Method 
 to ask the user to enter their name and write a Method that prints
 to the console:  "Hello user's name (insert real name)"
 I am attempting to get a 3 on this assignment so I have exceeded 
 expectations by adding a personalized message for specific user input
 for the names :"Tom Brady", "Victor Hedman", and "Austin Meadows".
 Keep in mind the names are case sensitive
 */

using System;

namespace Samsock_TechnicalProject_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter your name.");


            try
            {
                //Gather information from user
                string input = Console.ReadLine();


                if (input == "Tom Brady")
                {
                    Console.WriteLine("Hello " + input.ToString() + "!");
                    Console.WriteLine("Go Bucs!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (input == "Victor Hedman")
                {
                    Console.WriteLine("Hello " + input.ToString() + "!");
                    Console.WriteLine("Go Bolts!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (input == "Austin Meadows")
                {
                    Console.WriteLine("Hello " + input.ToString() + "!");
                    Console.WriteLine("Go Rays!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else
                {
                    provide_name(input);
                }
            }//END TRY
            catch
            {
                Console.WriteLine("A problem has occured, please try again...");
                Console.WriteLine("Press any key to exit and try again");
                Console.ReadKey(true);
            }
        } // END MAIN

        static void provide_name(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
             Console.WriteLine("You cannot have a null or emplty value.");
             Console.WriteLine(" ");
             Console.WriteLine("Press any key to exit the program and try again...");
             Console.ReadKey(true);
            }
            else
            {
            Console.WriteLine("Hello " + input.ToString() + "!");
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);
            }
                
        }
    }
}
