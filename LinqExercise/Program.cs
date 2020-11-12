using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            Console.WriteLine(numbers.Sum() + "is the sum of numbers");
            Console.WriteLine(numbers.Average() + "is the average of numbers");
            //Order numbers in ascending order and decsending order. Print each to console.
            var ascNums = numbers.OrderBy(x => x);
            var descNums = numbers.OrderByDescending(x => x);
            Console.WriteLine("ascending");
            foreach (var x in ascNums) { Console.WriteLine(x); }
            Console.WriteLine("now descending");
            foreach (var x in descNums) { Console.WriteLine(x); }
            Console.WriteLine("\n");
            //Print to the console only the numbers greater than 6
            foreach (var x in numbers.Where(v => v > 6)) { Console.WriteLine(x); }
            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("\n");
            foreach (var x in descNums.Take(4)) { Console.WriteLine(x); }
            Console.WriteLine("\n");

            //Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 36;
            var descAgeNums = numbers.OrderByDescending(x => x);
            foreach (var x in descAgeNums) { Console.WriteLine(x); }

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            var empfirInitCorS = employees.Where(name => name.FirstName.StartsWith('C') || name.FirstName.StartsWith('S'));
            foreach (var name in empfirInitCorS) { Console.WriteLine(name.FullName);}
            Console.WriteLine("\n");
            var sortedCSEmpList = empfirInitCorS.OrderBy(x => x.FirstName);
            foreach (var name in sortedCSEmpList) { Console.WriteLine(name.FullName); }
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            var ageOver26 = employees.Where(their => their.Age > 26);
            foreach (var person in ageOver26) { Console.WriteLine(person.FullName + " Age: " + person.Age); }
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            var ExpAndAge = employees.Where(their => their.YearsOfExperience <= 10 && their.Age > 35);
            Console.WriteLine("Total years of Experience:" + ExpAndAge.Sum(exp => exp.YearsOfExperience));
            Console.WriteLine("Average Years of Experience:" + ExpAndAge.Average(exp => exp.YearsOfExperience));
            //Add an employee to the end of the list without using employees.Add()
            employees.Append(new Employee("Minfilia", "Warde", 27, 10));
            var last = employees.Count();
            
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
