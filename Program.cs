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
            //Ask user to enter their name into the console
            Console.WriteLine("Hello! Please enter your name.");


            try
            {
                //Gather information from user
                string input = Console.ReadLine();

                //Customized input response for name: "Tom Brady"
                if (input == "Tom Brady")
                {
                    //Reads the name back to the user 
                    Console.WriteLine("Hello " + input.ToString() + "!");
                    //Personalized response for this specific input
                    Console.WriteLine("Go Bucs!");
                    Console.WriteLine("Press any key to exit the program...");
                    // Allows the user to press any key to exit
                    Console.ReadKey(true);
                }
                //Customized input response for the name: "Victor Hedman"
                else if (input == "Victor Hedman")
                {
                    //Reads the name back to the user
                    Console.WriteLine("Hello " + input.ToString() + "!");
                    //Personalized response for this specific input
                    Console.WriteLine("Go Bolts!");
                    Console.WriteLine("Press any key to exit the program...");
                    // Allows the user to press any key to exit
                    Console.ReadKey(true);
                }
                //Customized input response for the name: "Austin Meadows"
                else if (input == "Austin Meadows")
                {
                    //Reads the name back to the user
                    Console.WriteLine("Hello " + input.ToString() + "!");
                    //Personalized response for this specific input
                    Console.WriteLine("Go Rays!");
                    Console.WriteLine("Press any key to exit the program...");
                    // Allows the user to press any key to exit
                    Console.ReadKey(true);
                }
                else
                {
                    //Execute method to show the user's entered name 
                    provide_name(input);
                }
            }//END TRY
            catch
            {
                //Catch response
                Console.WriteLine("A problem has occured, please try again...");
                Console.WriteLine("Press any key to exit and try again");
                Console.ReadKey(true);
            }
        } // END MAIN

        //Method which displays the desired message 
        static void provide_name(string input)
        {
            //IF statement to make sure the user inputs something
            if (string.IsNullOrEmpty(input))
            {
             Console.WriteLine("You cannot have a null or emplty value.");
             Console.WriteLine(" ");
             Console.WriteLine("Press any key to exit the program and try again...");
             Console.ReadKey(true);
            }
            else
            {
            //Display the desired message back to the user.
            Console.WriteLine("Hello " + input.ToString() + "!");
            Console.WriteLine("Press any key to exit the program...");
             // Allows user to press any key to exit
            Console.ReadKey(true);
            }//END ELSE

        }// END provide_name
    }// END CLASS
} //END NAMESPACE
