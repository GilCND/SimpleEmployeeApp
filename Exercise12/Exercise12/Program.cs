/*
Programmer: Felipe SG
Date: 12/01/2021
Program: Exercise12
Objective: 
A company dealing with marketing wants to keep a data record of its
employees. Each record should have the following characteristic – first
name, last name, age, gender (‘m’ or ‘f’) and unique employee number
(27560000 to 27569999). Declare appropriate variables needed to
maintain the information for an employee by using the appropriate data
types and attribute names
 */

using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Appropriate data types and names
            string firstName;
            string lastName;
            sbyte age;
            char gender;
            uint uniqueNumber;
                
                // Code example (no error checking)
                Console.WriteLine("Welcome to data record system \n");
                Console.WriteLine("Please inform the First name of the employee: ");
                firstName = Console.ReadLine();
                Console.WriteLine("Please inform the Last name of the employee: ");
                lastName = Console.ReadLine();
                Console.WriteLine("Please inform the Age of the employee: ");
                age = Convert.ToSByte(Console.ReadLine());
                Console.WriteLine("Please inform the Gender of the employee: ");
                gender = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Please inform an unique employee number: ");
                uniqueNumber = Convert.ToUInt32(Console.ReadLine());

                Console.WriteLine("The name of the employee is: {0} {1} \n", firstName, lastName);
                Console.WriteLine("The age of the employee is: {0} \n",age);
                Console.WriteLine("The gender of the employee is: {0} \n", gender);
                Console.WriteLine("The unique employee number is: {0} \n", uniqueNumber);


        }
    }
}
