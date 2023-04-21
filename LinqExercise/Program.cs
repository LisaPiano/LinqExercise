using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine("The sum of numbers is: ");

           Console.WriteLine(numbers.Sum());
            Console.WriteLine("------------------------------------------");

            //TODO: Print the Average of numbers


            Console.WriteLine("The average of the numbers is: ");
            Console.WriteLine(numbers.Average());
            Console.WriteLine("____________________________________________________");
           

            //TODO: Order numbers in ascending order and print to the console

          Console.WriteLine("Ordering the numbers in ascending order: ");
          var ascent =  numbers.OrderBy(x => x);

            foreach (int x in ascent)
            {
                Console.WriteLine(x);
             }

            Console.WriteLine("___________________");

            //TODO: Order numbers in decsending order and print to the console

            Console.WriteLine("Ordering the numbers in descending order: ");

            var descent = numbers.OrderByDescending(x => x);

            foreach (int x in descent)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("_____________________________________________________");
            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Here are all of the numbers greater than 6: ");

            var greaterThanSix = numbers.Where(x => x > 6);   

            foreach (int x in greaterThanSix)
            { 
                Console.WriteLine(x);
            }

            Console.WriteLine("_____________________________________________________");

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Here are the first 4 numbers in ascending order: ");

            foreach (int x in ascent.Take(4)) {
                Console.WriteLine(x);
            }

            Console.WriteLine("_____________________________________________________");


            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("I inserted the age of Yoda at index 4, but then printed the numbers in descending order. Because Yoda is very old, his age appeared first in the descening list.");

            numbers.SetValue(900, 4);

            foreach (int x in numbers.OrderByDescending(num => num))
            { 
                Console.WriteLine(x);
            }
            Console.WriteLine("_____________________________________________________");



            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("Here, I will print in ascending order the full names of the employees whose first names begin with either C or S: ");
            var names = employees.Where(name => name.FirstName[0] == 'C' || name.FirstName[0] == 'S').OrderBy(num => num.FirstName).ToList();


            foreach (var name in names)
            { 
                Console.WriteLine(name.FirstName);
            }
  

            Console.WriteLine("_____________________________________________________");

            //TODO: Print all the employees' /*FullName*/ and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("FullName and Age of employees who are over 26 and ordered by Age and then by FirstName");

            var overTwentySix = employees.Where(name => name.Age > 26).OrderBy(num => num.Age).ThenBy(person => person.FirstName);

            foreach (var name in overTwentySix)
            {
                Console.WriteLine($"FullName: {name.FullName}, Age: {name.Age}");
            }





            Console.WriteLine("_____________________________________________________");




            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("Sum and Average of the employees' Years of Experience, if their Years of experience is <= 10 and their age is over 35.");

            var filteredEmployees = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35);

            Console.WriteLine($"The sum of the employees' Years of Experience is: {filteredEmployees.Sum(person => person.YearsOfExperience)}");
            Console.WriteLine($"The average of the employees' Years of Experience is: {filteredEmployees.Average(person => person.YearsOfExperience)}");

            Console.WriteLine("_____________________________________________________");

            Console.WriteLine("Add an employee to the end of the list without using employees.Add()");

            employees = employees.Append(new Employee("Lisa", "Campi Walters", 900, 1)).ToList();

          foreach (var employee in employees)
            {
                Console.WriteLine($"First name is: {employee.FirstName}, and last name is: {employee.LastName}");            }



            Console.WriteLine("_____________________________________________________");

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
