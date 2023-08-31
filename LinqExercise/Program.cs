using System;
using System.Collections.Generic;
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
            Console.WriteLine("--------------------------------------");
            //TODO: Print the Sum of numbers
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("--------------------------------------");
            //TODO: Print the Average of numbers
            Console.WriteLine(numbers.Average());
            Console.WriteLine("--------------------------------------");
            //TODO: Order numbers in ascending order and print to the console
            var ascending = numbers.OrderBy(num => num).ToArray();
            foreach (int i in ascending) { Console.WriteLine(i); }
            Console.WriteLine("--------------------------------------");
            //TODO: Order numbers in descending order and print to the console
            var descending = numbers.OrderByDescending(num => num).ToArray();
            foreach (int i in descending) { Console.WriteLine(i); }
            Console.WriteLine("--------------------------------------");
            //TODO: Print to the console only the numbers greater than 6
            var greaterThan6 = numbers.Where(num => num > 6).ToArray();
            foreach (int i in greaterThan6) { Console.WriteLine(i); }
            Console.WriteLine("--------------------------------------");
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var onlyFirst4 = numbers.OrderBy(num => num).Take(4).ToArray();
            foreach (int i in onlyFirst4) { Console.WriteLine(i); }
            Console.WriteLine("--------------------------------------");
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers.SetValue(42, 4);
            var index4ToMyAgeDescending = numbers.OrderByDescending(i => i).ToArray();
            foreach (int i in index4ToMyAgeDescending) { Console.WriteLine(i); }
            Console.WriteLine("--------------------------------------");
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var customEmpList = employees.Where(name => name.FirstName.ToLower().StartsWith('c') || name.FirstName.ToLower().StartsWith('s')).OrderBy(name => name.FirstName).ToArray();
            foreach (var name in customEmpList) { Console.WriteLine(name.FullName); }
            Console.WriteLine("--------------------------------------");
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var customAgeList = employees.Where(age => age.Age > 26 ).OrderByDescending(age => age.Age).ThenBy(name => name.FirstName).ToArray();
            foreach (var name in customAgeList) { Console.WriteLine($"Name :{name.FullName}, Age: {name.Age}"); }
            Console.WriteLine("--------------------------------------");
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var customYOESumAndAvg = employees.Where(_v => _v.Age > 35 && _v.YearsOfExperience <= 10).ToArray();
            Console.WriteLine($"Sum of Years of Experience: {customYOESumAndAvg.Sum(_v => _v.YearsOfExperience)}.");
            Console.WriteLine($"Average of Years of Experience: {customYOESumAndAvg.Average(_v => _v.YearsOfExperience)}.");
            Console.WriteLine("--------------------------------------");
            //TODO: Add an employee to the end of the list without using employees.Add()
            var newEmployee = new Employee("Bryson", "Varner", 42, 1);
            var currentEmployees = employees.Append(newEmployee);

            foreach (var employee in currentEmployees ) {  Console.WriteLine( employee.FullName ); };


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
