using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace code_base_1
{
    using System;

    public class TicketsException : Exception
    {
        public TicketsException(string message) : base(message)
        {
        }
    }
    public class Passanger
    {
        private int age;
        private string dateOfTravel;
        private int noOfTickets;
        private string name;
        public Passanger(int age, string dateOfTravel, string name)
        {
            this.age = age;
            this.dateOfTravel = dateOfTravel;
            this.name = name;
        }
        public void TicketBooking(int noOfTickets)
        {
            if (noOfTickets > 5)
            {
                throw (new TicketsException("cannot book more than 5 tickets"));
            }
            else
            {
                this.noOfTickets = noOfTickets;
                Console.WriteLine("Ticket Booked Sussfully");
            }
        }
    }
    class Test
    {

        public static void Main(string[] args)
        {
            Passanger passenger = new Passanger(25, "05-05-2022", "Konda Reddy");
            passenger.TicketBooking(5);
            Console.ReadKey();
        }
    }
}