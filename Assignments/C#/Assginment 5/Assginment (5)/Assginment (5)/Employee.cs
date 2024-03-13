using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Assignment_5

{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }

        public Employee(int empId, string empName, double salary)
        {
            EmployeeId = empId;
            EmployeeName = empName;
            Salary = salary;
        }
    }

    class PartTimeEmployee : Employee
    {
        public float HourlyWage { get; set; }

        public PartTimeEmployee(int empId, string empName, double salary, float hourlyWage) : base(empId, empName, salary)
        {
            HourlyWage = hourlyWage;
        }
    }

    class TestEmp
    {
        public static void SetDisplayEmployee()
        {
            // Create an Employee instance and pass the values
            Console.Write("Enter Employee Id: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            double empSalary = Convert.ToDouble(Console.ReadLine());

            Employee employee = new Employee(empId, empName, empSalary);

            // Create a PartTimeEmployee instance and pass the values
            Console.Write("Enter Part Time Employee ID: ");
            int partEmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Part Time Employee Name: ");
            string partEmpName = Console.ReadLine();
            Console.Write("Enter Part Time Employee Salary: ");
            double partEmpSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Part Time Employee Hourly Wage: ");
            float partHourlyWage = Convert.ToSingle(Console.ReadLine());

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(partEmpId, partEmpName, partEmpSalary, partHourlyWage);

            // Display details of Employee
            Console.WriteLine($"Employee ID: {employee.EmployeeId}, Name: {employee.EmployeeName}, Salary: {employee.Salary}");

            // Display details of Part Time Employee
            Console.WriteLine($"Part-Time Employee ID: {partTimeEmployee.EmployeeId}, Name: {partTimeEmployee.EmployeeName}" +
                               $", Salary: {partTimeEmployee.Salary}, Hourly Wage: {partTimeEmployee.HourlyWage}");
        }

        static void Main()
        {
            SetDisplayEmployee();
        }
    }
}
