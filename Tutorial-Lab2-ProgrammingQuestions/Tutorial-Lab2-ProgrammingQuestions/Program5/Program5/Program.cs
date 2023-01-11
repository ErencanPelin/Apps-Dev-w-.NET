﻿using System;
/*
Week3 Lab Program:
 
Questions:
Write a C# Program to read a number ‘n’ from the user and generate the first ‘n’ numbers of a Fibonacci series:
Example:
Enter the number of terms to display: 10
The Fibonacci series is: 0 1 1 2 3 5 8 13 21 34

 Hint:
 By definition, the first two numbers in the Fibonacci sequence are either 1 and 1, or 0 and 1, 
 depending on the chosen starting point of the sequence, and each subsequent number is the sum of the previous two.

The sequence Fn of Fibonacci numbers is defined by the recurrence relation:

Fn = Fn-1 + Fn-2
Let, F1 = 0 and F2 = 1

Hence, F3 = F2 + F1, F3 = 0 + 1 =1
 
Reference: https://en.wikipedia.org/wiki/Fibonacci_number
    */

namespace Week3LabProgram
{
    class FibonacciSeries
    {
        public static void Main(string[] args)
        {
            // Write code to declare the requried variables

            // Write code to Display message to ask the user to enter the number of term to be displayed 
            // for the Fibonacci series
            Console.Write("Enter the number of terms to display: ");
            var userInput = int.Parse(Console.ReadLine());

            // Start calculating the terms and displaying them
            Console.WriteLine("The Fibonacci series is: ");
            // Write code to display the first 2 terms
            Console.Write("0 ");

            // Write code to Create a loop to calculate and display the Fibonacci numbers
            int n1 = 0;
            int n2 = 1;
            int n;
            for (var i = 0; i <= userInput - 2; i++)
            {
                n = n1 + n2;
                n2 = n1;
                n1 = n;
                // Write code to Display the next terms 
                Console.Write($"{n} " );
            }

            // Write code to Accept a key press from user
            Console.ReadKey();
        }
    }
}

/*
Test case:

Enter the number of terms to display: 10
The Fibonacci series is:
0 1 1 2 3 5 8 13 21 34

    */
