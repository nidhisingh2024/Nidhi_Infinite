using System;

namespace Assessment2
{
    class Student
    {
        private int rollNo;
        private string name;
        private string studentClass;
        private int semester;
        private string branch;
        private int[] marks = new int[5];

        public Student(int rollNo, string name, string studentClass, int semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.studentClass = studentClass;
            this.semester = semester;
            this.branch = branch;
        }

        public void InputMarks()
        {
            Console.WriteLine("Enter the marks of five subjects: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            Console.WriteLine("-----Student Information-----");
            Console.WriteLine($"Roll Number: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {studentClass}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");

            Console.WriteLine("---Marks---");
            int sum = 0;
            foreach (int mark in marks)
            {
                Console.WriteLine($"Subject: {mark}");
                sum += mark;
            }

            double average = (double)sum / marks.Length;
            Console.WriteLine($"Total Marks obtained by Student: {sum}");
            Console.WriteLine($"Average Marks: {average:N2}");
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student(444, "nidhi", "B.tech", 1, "CSE");
            student.InputMarks();
            student.DisplayResult();
            Console.Read();
        }
    }
}