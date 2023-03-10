using System;
using System.IO;
/*
 The given text file contains 5 set of user IDs and Password. 
 The file stores userID and password in the following format:
<User>, <password>
Hello, abc1234
Admin, admin,
User, user
Write a program to read a given text file and print the data about the user Id and password. 
Write appropriate exception handling code to handle exceptions which might occur while reading the text file.  
 */


namespace Week6LabProgram
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Write the code to create a try block
            try
            {
                // Write the code to read the text file line wise
                // Hint: Use ReadAllLines()
                string[] fromFile = File.ReadAllLines("userIdDB.txt");

                // Split each line using "," as delimiter and print the values as
                // User Name: ------, Passowrd: .... "
                // Hint: use foreach loop
                foreach (var str in fromFile)
                {
                    // Write the code to Split each line and store it in a String Array
                    string[] splitStr = str.Split(',');
                    //Write the code to Display the values of username and password
                    // Write the code to Check the test case format
                    Console.WriteLine($"Username: {splitStr[0]}, Password: {splitStr[1]}");
                }
                // Write the code to Read a key from user                
                Console.ReadKey();
            }
            // Catch the FileNotFoundException exception
            catch (FileNotFoundException)
            {
                // Write the code to Display the error message
                Console.WriteLine("File not found!");
                // Write the code to Read a key from user   
                Console.ReadKey();
            }
        }
    }
}

/*
Test Case:
Expeted Output: 

UserName: admin, Password: admin
UserName: normaluser, Password: user
UserName: Adam, Password: hello
UserName: George, Password: yessir
UserName: hacker, Password: nohack

    */