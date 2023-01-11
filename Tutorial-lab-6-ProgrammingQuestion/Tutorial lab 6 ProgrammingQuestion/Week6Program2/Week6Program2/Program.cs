using System;
/*
Write a program to create a Shape Class and derive two child class, Rectangle and Circle, based 
the specification given in the Tutorial instructions.
 The Base class implementation is provided.
 */
namespace Week6LabProgram
{
    // Base Class Shape
    public class Shape
    {
        // Data members/properties
        public int NumberOfSides { get; set; }

        // Constructor
        public Shape(int NoSides)
        {
            NumberOfSides = NoSides;
        }

        // Virtual method Area() to be overidden by Child class
        public virtual double Area() => 0;
        // Virtual method Display() to be overidden by Child class
        public virtual void Display()
        {
            Console.WriteLine("The Number of Sides are: {0}", NumberOfSides);
        }
    }

    // Create the Child class Circle derived from Shape
    public class Circle : Shape
    {
        // Write the code for Data member/properties
        double radius;
        const double pi = 3.142;

        // Write the code for Constructor
        public Circle(double radius): base(1) => this.radius = radius;

        // Write the code to override the base class Area() method
        public override double Area() => pi * (radius * radius);

        // Write the code to override the base class Display() method
        public override void Display()
        {
            Console.WriteLine("\nThe Number of sides of a Circle is : {0}", NumberOfSides);
            Console.WriteLine("The Radius of the Circle is: {0}", radius);
            Console.WriteLine("The Area of Circle is : {0}", Area());
        }
    }

    // Create the child class Rectangle derived from Shape
    public class Rectangle : Shape
    {
        // Write the code for Data member/properties
        double length, breadth;
        
        // Write the code for Constructor
        public Rectangle(double length, double breadth) : base(4)
        {
            this.length = length;
            this.breadth = breadth;
        }
        // Write the code to override the base class Area() method
        public override double Area() => length * breadth;
        // Write the code to override the base class Display() method
        public override void Display()
        {
            //  hint: Check the Display method of the Circle class to complete the code.
            Console.WriteLine("\nThe Number of sides of a Rectangle is : {0}", NumberOfSides);
            Console.WriteLine("The Length and Breadth of the Rectangle is: {0}, {1}", length, breadth);
            Console.WriteLine("The Area of Rect is : {0}", Area());
        }
    }
    class Week6Program2
    {
        static void Main(string[] args)
        {
            // Create Circle and Rectangle Objects
            Circle C1 = new Circle(4);
            Rectangle R1 = new Rectangle(5, 4);

            // Calculate the area
            C1.Area();
            R1.Area();

            // Display the dimensions and area of Circle and Rectangle
            C1.Display();
            R1.Display();

            Console.ReadKey();
            
        }
    }
}

/*
  Test Case:
    The Number of sides of a Circle is : 1
    The Radius of the Circle is: 4
    The Area of Circle is : 50.272

    The Number of sides of a Rectangle is : 4
    The Length and Breadth of the Rectangle is: 5, 4
    The Area of Rectangle is : 20
  
 */
