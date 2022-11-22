using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketOOP
{
    public class Ticket
    {
        private string movie;
        public string Movie
        {
            get { return movie; }
            set { movie = value; }
            // {
            //     if (value == "")
            //      Movie = "7 vien bi rong";
            //     else Movie = value;
            // }
        }
        //Movie = "7 vien bi rong";

        private string seats;
        //seats
        public string Seats
        {
            get { return seats; }
            set { seats = value; }
            // {
            //     if (value == "")
            //     Seats = "ABCD";
            //     else Seats = value;
            // }
        }
        //number
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
            // {
            //     if (value == 0)
            //     Number = 69;
            //     else Number = value;
            // }
        }
        //Ticket
        public Ticket()
        {
            Movie = "7 vien bi rong";
            Seats = "1A";
            Number = 1;
        }
        //
        public Ticket(string movie, string seats, int number )
        {
            Movie = movie;
            Seats = seats;
            Number = number;
        }
    }
}