using System;
using System.Linq;

/*
Write a program to Create Student a Result management System with the following specifications:
1. There are two classes, Person (Abstract base class), Student(derived class from person)
2. There is one Interface for Generating the Results

Please refer to the instructions document for the class diagrams and Instructions.

    */

namespace Week6LabProgram
{
    // Create an Abstract class person
    public abstract class Person
    {
        //Write code to Declare data members/properties here
        public string personName { get; protected set; }
        public string personAddress { get; protected set; }

        // Write code for Constructor
        protected Person(string personName, string personAddress)
        {
            this.personName = personName;
            this.personAddress = personAddress;
        }          
    }

// Write code toCreate an Interface IResults for creating marksheet
    public interface IResults
    {
        // Declare the methods to be inplemented in the class

        // Write code for Method to get the marks for 5 subjects
        void GetMarks();
        // Write code for Method to calculate the final grade (Pass/Fail)
        string CalculateResult();
        //Write code for Method to Display the MarkSheet
        void DisplayResult();
    }

    // Write code to Create the Student class by inheriting the Person Class and implementing the IResults interface
    public class Student : Person, IResults
    {
        // Write code for Data members specific to a Student
        private string standard;
        private string roll;
        private double[] marks;

        // Write code for Student Constructor, which also initializes the base class properties
        public Student(string personName, string personAddress, string standard, string roll) : base(personName, personAddress) 
        {
            // Write code here
            this.standard = standard;
            this.roll = roll;
            marks = new double[5];
        }
        
        // Implement the GetMarks() method
        public void GetMarks()
        {
       //     Console.WriteLine("Marks Obtained:");
            // Accept the marks for 5 subjects and store it in an array
            for(int loopVar = 0; loopVar < 5; loopVar++)
            {
                // Write code to to accept marks for 5 subjects
                Console.Write($"Enter marks for Subject-{loopVar + 1}: ");
                marks[loopVar] = double.Parse(Console.ReadLine());
            }
        }
        // Implement the CalculateResult() method
        public string CalculateResult()
        {
         // Calculate the sum of the marks obtained// Hint: mark.Sum()
            double totalMarksObtained = marks.Sum();
            // Find the grade and return it
            // Averge <40, grade = Fail
            // Else Pass
            return (totalMarksObtained / 5 < 40) ? "Failure!" : "You passed, GG";
        }

        // Implement the DisplayResult() method to generate the Marksheet
        public void DisplayResult()
        {
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("\t\tMark Sheet");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Name: {personName}");
            Console.WriteLine($"Class: {standard}");
            Console.WriteLine($"Roll: {roll}");
            Console.WriteLine($"Address: {personAddress}\n");
            // Write code to to display the marksheet as per format given in test case
            Console.WriteLine("Marks Obtained:");
            for (int loopVar = 0; loopVar < 5; loopVar++)
            {
                // Write code to to accept marks for 5 subjects
                Console.WriteLine($"Subject-{loopVar + 1}: {marks[loopVar]}");
            }
            Console.Write($"\nAverage: {marks.Sum() / 5}\n");
        }

    }
    class Week6Program1
    {
        static void Main(string[] args)
        {
            // Write code to Create a Student object
            Student s1 = new Student("Eren Pelin", "25 Ultimo St", "V", "1004");
            // Write code to Get the student's marks
            s1.GetMarks();
            // Write code to Generate the Marks Sheet
            s1.DisplayResult();
            Console.WriteLine($"Final Grade: {s1.CalculateResult()}");


            // Accept a key press from user.
            Console.ReadKey();
        }
    }
}

/* Test Case:

Enter Marks for Subject-1:56
Enter Marks for Subject-2:42
Enter Marks for Subject-3:89
Enter Marks for Subject-4:69
Enter Marks for Subject-5:95

---------------------------------------------
                Mark Sheet
---------------------------------------------
Name: George Woolsworth
Class: V
Roll: 1004
Address: Ultimo, Sydney 2007, Australia

Marks Obtained:
Subject-0: 57
Subject-1: 43
Subject-2: 90
Subject-3: 70
Subject-4: 96

Average Marks: 70.2
Final Grade: Pass
---------------------------------------------

    
    */
