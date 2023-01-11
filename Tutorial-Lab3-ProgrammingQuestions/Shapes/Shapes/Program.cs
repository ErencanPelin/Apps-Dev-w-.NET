using System;
/*Write a program to define a Shape class. The Shape class will be used to create two objects: Circle and Rectangle, 
and calculate their areas.Shape class should have constructors to initialize circle(with radius) and rectangle(with height and width).

 There should be two methods to calculate the area of circle and rectangle.
 The Shape objects should be created in the class containing the main() method.Please use the below class diagram :
 
 -------------------------------
 | Shape                      |
 -------------------------------
 | - height: double			  |
 | - width: double			  |
 | - radius : double	      |
 | - pi : double (const)      |
 -------------------------------
 | + Shape(ht, wd)			   |
 | + Shape(rad)                |
 | + rectangleArea():double    |
 | + circleArea()::double      |
 | + Display(shapetype)        |
 -------------------------------
 The object should be initialized using respective constructors
 
 Example:
Radius of circle is: 4.0
Height and Width of rectangle is: 5.0 ,4.0
Area of Circle is: 50.26548245743669
Area of Rectangle is: 20.0

Hint:
1. For area of circle use pi =3.142, Area = PI * radius * radius
2. Area of rectangle = height * width
3. Check the main method before creating the shape class
 */

namespace Week4LabProgramQuestion
{
    class Shapes
    {
        // Complete the code to declare Private fields
        private double height;
        private double width;
        private double radius;
        private const double pi = 3.141592653589790; // Define the value of pi

        //Write code to Define Constructor to create a Circle
        public Shapes(double radius) => this.radius = radius;

        //Write code to Define Constructor to create a rectangle
        public Shapes(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        //Write code for the Method to calculate the area of Rectangle
        public double GetRectArea() => height * width;

        //Write code for the Method to calculate the area of Circle
        public double GetCircleArea() => pi * Math.Pow(radius, 2);

        // Write code for the Display Method 
        // it takes a char (r for rectangle, c or circle) as an argument
        public void Display(char shapeType)
        {
            // Complete the code below
            switch (shapeType)
            {
                case 'r':
                {
                    Console.WriteLine($"Height and Width of rectangle is: {height}, {width}");
                    break;
                }
                case 'c':
                {
                    Console.WriteLine($"Radius of circle is: {radius}");
                    break;
                }
                default: break;
            }
        }
    }
    class ShapesTest
    {
        static void Main(string[] args)
        {
            // Complete the code to Create Shape object as per test case
            Shapes circle = new Shapes(4);
            Shapes rectangle = new Shapes(5, 4);

            // Complete the code to Display the object properties
            circle.Display('c');
            rectangle.Display('r');

            // Complete the code Calculate and display the area of the objects
            Console.WriteLine($"The area of circle is {circle.GetCircleArea()}");
            Console.WriteLine($"The area of rectangle is {rectangle.GetRectArea()}");

            // Accept a key press from user
            Console.ReadKey();
        }
    }
}

/*
The program should produce the following result
  Test case 1:
  Initialize the circle with radius: 4
  Initialize the rectangle with ht and wd: 5, 4
  
  Expected output:
  Radius of circle is: 4.0
  Height and Width of rectangle is: 5.0 ,4.0
  Area of Circle is: 50.26548245743669
  Area of Rectangle is: 20.0

  Test case 2:
  Initialize the circle with radius: 10
  Initialize the rectangle with ht and wd: 15, 5
  Note the result
  

 */
