using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOCTOR

{


    class Doctor
    {
        // Private member variables
        private int RegnNo;
        private string Name;
        private decimal FeesCharged;

        // Method to set values for member variables
        public void SetValues(int regnNo, string name, decimal feesCharged)
        {
            RegnNo = regnNo;
            Name = name;
            FeesCharged = feesCharged;
        }

        // Method to display member variables
        public void Display()
        {
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fees Charged: {FeesCharged}");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Doctor class
            Doctor doctor = new Doctor();

            // Set values for the doctor
            doctor.SetValues(1234, "Nidhi Singh", 100);

            // Display the doctor's information
            doctor.Display();
        }
    }

}
