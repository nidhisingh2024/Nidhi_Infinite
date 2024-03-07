using System;

// This is abstract class of student
public abstract class Student
{
   
    public string Name { get; set; }
    public int StudentId { get; set; }
    public double Grade { get; set; }

    public abstract bool IsPassed(double grade);
}
public class Undergraduate : Student
{

    public override bool IsPassed(double grade)
    {
        return grade > 70.0;
    }
}


public class Graduate : Student
{

    public override bool IsPassed(double grade)
    {
        return grade > 80.0;
    }
}

class Student_Details

{
    static void Main(string[] args)
    {
        //for undergraduates student
        Undergraduate undergrad = new Undergraduate();
        undergrad.Name = "Seema";
        undergrad.StudentId = 444;
        undergrad.Grade = 75.0;

        //for graduate student
        Graduate grad = new Graduate();
        grad.Name = "Nidhi";
        grad.StudentId = 555;
        grad.Grade = 85.0;

        //check Conditions
        Console.WriteLine($"{undergrad.Name} has {(undergrad.IsPassed(undergrad.Grade) ? "passed" : "failed")}.");
        Console.WriteLine($"{grad.Name} has {(grad.IsPassed(grad.Grade) ? "passed" : "failed")}.");
        Console.ReadLine();
    }
}
