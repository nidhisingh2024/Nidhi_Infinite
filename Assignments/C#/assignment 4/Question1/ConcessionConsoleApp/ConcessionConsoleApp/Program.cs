﻿using System;
using System.Collections.Generic;
using System.Linq;
using Consession;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionConsoleApp
{
    class Program
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private const int TOTAL_FARE = 600;


        static void Main(string[] args)
        {
            Program pg = new Program();

            Console.Write("Enter Age: ");
            pg.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            pg.Name = Console.ReadLine();

            TicketConcession ticketConc = new TicketConcession();

            ticketConc.CalculateConcession(pg.Age, pg.Name);

            Console.Read();
        }
    }
}
