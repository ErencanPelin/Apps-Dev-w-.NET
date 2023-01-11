using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Program1
{
    class EmployeeList
    {
        // Write code for to Create a List to store the information from emp.txt file
        private List<Employee> employeeList;

        // EmployeeList constructor
        public EmployeeList()
        {
            // Create an instance of List<>
            employeeList = new List<Employee>();
        }

        // Method to process a string which contain a single line for the emp.txt
        // The lfile name is passed as a parameter to the Method
        public void LoadEmployees(string filename)
        {
            // Read the file content using the StreamReader
            StreamReader fileContent = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), @"emp.txt"));
            // Create an object of Employee class
            Employee emp;

            // Read the StremReader till the last line
            while (!fileContent.EndOfStream)                                                                                                                                                                                                             
            {
                // At this point there are still employees to be loaded

                // Write code to Read each line and from the StreamReader
                string line = fileContent.ReadLine();
                // Write code to Load the employee detail from file to respective fields
                emp = new Employee();
                emp.LoadEmployee(line);
                // Write code to Add the details to the list collection
                employeeList.Add(emp);
            }
            // Write code to Close the StreamReader
            fileContent.Close();
        }

        // Method to display the details for all the Employee
        public void PrintEmployees()
        {
            // prints each employee details in the employees list on a seperate line
            foreach(var e in employeeList)
                Console.WriteLine(e.ToString());
        }
    //  Write code to Sort the employee details based on the Employee ID
        public void SortEmployees() => employeeList.Sort();
    }
}
