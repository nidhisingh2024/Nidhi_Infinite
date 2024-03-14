using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3

{
    class Program
    {
        static void Main(string[] args)
        {
            // Using list
            List<Employee> empList = new List<Employee>()
            {
                new Employee(1001, "Malcolm", "Daruwalla", "Manager", "16/11/1984", "8/6/2011", "Mumbai"),
                new Employee(1002, "Asdin", "Dhalla", "AsstManager", "20/08/1984", "7/7/2012", "Mumbai"),
                new Employee(1003, "Madhavi", "Oza", "Consultant", "14/11/1987", "12/4/2015", "Pune"),
                new Employee(1004, "Saba", "Shaikh", "SE", "3/6/1990", "2/2/2016", "Pune"),
                new Employee(1005, "Nazia", "Shaikh", "SE", "8/3/1991", "2/2/2016", "Mumbai"),
                new Employee(1006, "Amit", "Pathak", "Consultant", "7/11/1989", "8/8/2014", "Chennai"),
                new Employee(1007, "Vijay", "Natrajan", "Consultant", "2/12/1989", "1/6/2015", "Mumbai"),
                new Employee(1008, "Rahul", "Dubey", "Associate", "11/11/1993", "6/11/2014", "Chennai"),
                new Employee(1009, "Suresh", "Mistry", "Associate", "12/8/1992", "3/12/2014", "Chennai"),
                new Employee(1010, "Sumit", "Shah", "Manager", "12/4/1991", "2/1/2016", "Pune")
            };

            // LINQ queries
            // a. Display detail of all the employees
            Console.WriteLine("Details of all employees:");
            foreach (var emp in empList)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine();

            // b. Display details of all the employees whose location is not Mumbai
            var empNotInMumbai = empList.Where(emp => emp.Emp_City != "Mumbai");
            Console.WriteLine("Details of employees not in Mumbai:");
            foreach (var emp in empNotInMumbai)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine();

            // c. Display details of all the employees whose title is AsstManager
            var asstManagers = empList.Where(emp => emp.Emp_Title == "AsstManager");
            Console.WriteLine("Details of employees with title AsstManager:");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine();

            // d. Display details of all the employees whose Last Name starts with S
            var empWithLastNameStartingWithS = empList.Where(emp => emp.Emp_LastName.StartsWith("S"));
            Console.WriteLine("Details of employees with last name starting with 'S':");
            foreach (var emp in empWithLastNameStartingWithS)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    // Employee class
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Emp_FirstName { get; set; }
        public string Emp_LastName { get; set; }
        public string Emp_Title { get; set; }
        public string Emp_DOB { get; set; }
        public string Emp_DOJ { get; set; }
        public string Emp_City { get; set; }

        public Employee(int id, string firstName, string lastName, string title, string dob, string doj, string city)
        {
            EmployeeID = id;
           Emp_FirstName = firstName;
            Emp_LastName = lastName;
            Emp_Title = title;
           Emp_DOB = dob;
            Emp_DOJ = doj;
            Emp_City = city;
        }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID}, Name: {Emp_FirstName} {Emp_LastName}, Title: {Emp_Title}, DOB: {Emp_DOB}, DOJ: {Emp_DOJ}, City: {Emp_City}";
        }
    }
}
