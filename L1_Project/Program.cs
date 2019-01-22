using System;

namespace L1_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            // Eg. a=3, b=4, c=5. Area = 6


            // Exercise 2
            // Input a number (n) from the user and check if it is even or odd.

            // Write your code here

            //Direct user to enter a number
            Console.WriteLine("Please enter a number");
            //Read in user input as a string
            string n = Console.ReadLine();
            //Cast string variable n as integer variable m
            int m = int.Parse(n);
            //Determine if m is even by verifying that modulo divided by 2 equals 0, and print verification
            //Else return to user number is odd
            if (m % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd. ");
            }

            Console.ReadKey(true);

            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.

            // Write your code here
        }
    }
}
