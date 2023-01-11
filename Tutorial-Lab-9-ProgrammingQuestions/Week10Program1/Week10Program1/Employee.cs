using System;
using System.Collections.Generic;

namespace Week10Program1
{
    public class Employee : IComparable<Employee>
    {
        // Write code for the Properties of an Employee
        // Name (First and last name), ID#, hourly rate and total working hours per week
        private string employeeFName;
        private string employeeLName;
        private double hourlyRate;
        private double workHours;
        private int employeeID;

        // Write code for the Employee Constructor
        public Employee() { }

        // Write code for the Method to recieve a single line from the emp.txt file as string
        // and extract individual fields from the line by spltting the line using ','
        public void LoadEmployee(string file)
        {
            // Split the comma seperated string into fields 
            var @string = file.Split(',');

            // Assign values to respective properties/ members
            employeeFName = @string[0];    
            employeeLName = @string[1];
            hourlyRate    = double.Parse(@string[2]);
            employeeID    = int.Parse(@string[3]);    
            workHours     = double.Parse(@string[4]);
        }

        // Method to calculate the weekly salary of an Employee
        public double GetWeeklySal() => workHours * hourlyRate;
        // Overide the ToString() method to display the employee details
        public override string ToString() => $"{employeeFName} {employeeLName} ID#:{employeeID} Weekly Income: {GetWeeklySal()}";

        // Write code for the Implemention of the CompareTo method 
        public int CompareTo(Employee other)
        {
/*            return (employeeID < other.employeeID) switch
            {
                true => -1; 
                false when employeeID == other.employeeID => 1;
                _ => 0;
            }
*/
            switch (employeeID < other.employeeID)
            {
                case true: return -1;
                case false when employeeID == other.employeeID: return 1;
                default: return 0;
            }
        }

        int IComparable<Employee>.CompareTo(Employee other) => CompareTo(other);
    }
}
