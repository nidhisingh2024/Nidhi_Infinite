using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consession
{
    public class TicketConcession
    {
        private const int BaseFare = 600;

        public static void Main(string[] args)
        {
            TicketConcession ticketConcession = new TicketConcession();

        }

        public void CalculateConcession(int age, string name)
        {
            decimal fare;

            if (age <= 5)
            {
                Console.WriteLine($"Little Champs - Free Ticket, Name: {name}, Age: {age}");
                return;
            }
            else if (age > 60)
            {
                fare = BaseFare * 0.7m; // 30% discount for senior citizens
            }
            else
            {
                fare = BaseFare;
            }

            Console.WriteLine($"Ticket Booked - Fare: {fare}, Name: {name}, Age: {age}");
        }
    }
}
