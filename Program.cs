/*
    Author: Catherine Santos
    Date: 09/24/2020
    Comments: This C# Console application code demonstrates the use of 
              methods after getting input from a user. 

*/


using System;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Write method to display question asking user for input
            Console.Write("Please enter your first and last name: ");

            // This variable will gather the user's full name and used to display in greeting message
            string fullName = Console.ReadLine();

            // Call WriteLine method to display the greeting message with the user's name
            Console.WriteLine("Hello " + fullName + " - Dream Big");

            //Call WriteLine method to display instructions on how to exit program
            Console.WriteLine("Press any key to exit the program....");
            Console.ReadKey(true);
            }

    }
}
