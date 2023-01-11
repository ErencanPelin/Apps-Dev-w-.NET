using System;


/*
Program 1:
Write a C# Program to read 10 numbers as user input and find the following:
    a.	Sum of the numbers,
    b.	Average of the numbers,
    c.	Largest number, and 
    d.	Smallest number
    
    Without using arrays!

    Example:
    Enter 10 numbers: 1 2 3 4 5 6 7 8 9 10
    Sum = 55
    Average = 5.5
    Largest number = 10
    Smallest number = 1

    Hint:
    Read the numbers in a loop!

    ** Please Check the complete code and the test cases in order to 
       understand the control flow before trying to solve the questions
*/


namespace Week3LabProgram
{
    class Program1
    {
        static void Main(string[] args)
        {
            // Variable declaration
            // int for numbers, string for user input and float for average
            int[] nums = new int[10];
            string input;
            
            // Input 10 numbers from user in a loop and
            // compute the sum, largest and smallest number
            Console.WriteLine("Enter 10 numbers:"); // Enter the code here

            // Write the code initialize the for loop
            for(int i = 1; i <= 10; i++)
            {
                //Display message to user to enter a number
                // Complete the code
                Console.Write($"Enter number {i}: ");

                // Write the code Read the user input as string
                input = Console.ReadLine();

                //Convert user input from string to integer
                // Hint: use Convert.ToInt32()
                nums[i - 1] = Convert.ToInt32(input);
            }

            //Write the code to compute average
            var avg = Average(nums);

            // Complete the code to Display result
            Console.WriteLine($"\nSum = {Sum(nums)}");
            Console.WriteLine($"Largest Number: {Max(nums)}");
            Console.WriteLine($"Smallest number: {Min(nums)}");
            Console.WriteLine($"Average: {avg}");


            //Write the code to Accept a key entry from user
            Console.ReadKey();
        }

        static int Max(int[] array)
        {
            var max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) 
                    max = array[i];
            }
            return max;
        }

        static int Min(int[] array)
        {
            var min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) 
                    min = array[i];
            }
            return min;
        }

        static float Average(int[] array)
        {
            var sum = Sum(array);
            return sum / array.Length;
        }

        static float Sum(int[] array)
        {
            var sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;
        }
    }
}


/*
Test case:

    Enter 10 numbers:
    Enter number 1: 5
    Enter number 2: 6
    Enter number 3: 9
    Enter number 4: 8
    Enter number 5: 4
    Enter number 6: 5
    Enter number 7: 32
    Enter number 8: 1
    Enter number 9: 5
    Enter number 10: 2

    Sum = 77
    Largest Number: 32
    Smallest number: 1
    Average: 7.7


*/
