using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment_5
{
    // IStudent interface
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    // Dayscholar class that implements IStudent
    public class DayScholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string TransportationMode { get; set; }

        //override showDetails()
        public void ShowDetails()
        {
            Console.WriteLine($"Day-Scholar Details - Student ID: {StudentId}, Name: {Name}, Transportation Mode: {TransportationMode}");
        }
    }

    // Resident class that implements IStudent
    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string HostelName { get; set; }

        //override showDetails()
        public void ShowDetails()
        {
            Console.WriteLine($"Residential Details - Student ID: {StudentId}, Name: {Name}, Hostel Name: {HostelName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Test_Student();
        }
    }

    class Student
    {
        public void Test_Student()
        {
            // Input for DayScholar student
            Console.Write("Enter Day-Scholar Student ID: ");
            int dayScholarId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Day-Scholar Student Name: ");
            string dayScholarName = Console.ReadLine();
            Console.Write("Enter Transportation Mode: ");
            string transportationMode = Console.ReadLine();

            // Creating DayScholar object
            DayScholar dayScholar = new DayScholar { StudentId = dayScholarId, Name = dayScholarName, TransportationMode = transportationMode };

            // Input for Resident student
            Console.Write("Enter Resident Student ID: ");
            int residentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Resident Student Name: ");
            string residentName = Console.ReadLine();
            Console.Write("Enter Hostel Name: ");
            string hostelName = Console.ReadLine();

            // Creating Resident object
            Resident resident = new Resident { StudentId = residentId, Name = residentName, HostelName = hostelName };

            // Displaying details of students
            Console.WriteLine("\nDay-Scholar Details:");
            dayScholar.ShowDetails();
            Console.WriteLine("\nResidential Details:");
            resident.ShowDetails();
        }
    }
}
