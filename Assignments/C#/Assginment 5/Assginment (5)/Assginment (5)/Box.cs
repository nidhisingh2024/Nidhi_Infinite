using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoxNamespace
{
    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box Add(Box box1, Box box2)
        {
            double sumLength = box1.Length + box2.Length;
            double sumBreadth = box1.Breadth + box2.Breadth;

            return new Box(sumLength, sumBreadth);
        }

        public void Display()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
            Console.Read();
        }
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            int l1, l2, b1, b2;
            Console.WriteLine("Enter Box 1 lenght:  ");
            l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Box 1 bredth:  ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Box 2 lenght:  ");
            l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Box 2 bredth:  ");
            b2 = Convert.ToInt32(Console.ReadLine());

            Box box1 = new Box(l1, b1);
            Box box2 = new Box(l2, b2);

            Box sumBox = Box.Add(box1, box2);

            Console.WriteLine("Displaying value of First Box:");
            box1.Display();

            Console.WriteLine("Displaying value of Second Box:");
            box2.Display();

            Console.WriteLine("Total Sum of Boxes:");
            sumBox.Display();
        }
    }
}


