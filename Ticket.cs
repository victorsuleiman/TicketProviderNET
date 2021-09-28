using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketProvider
{
    public class Ticket
    {
        public int number;
        public TimeSlot timeSlot;

        public Ticket(int number, TimeSlot timeSlot)
        {
            this.number = number;
            this.timeSlot = timeSlot;
        }

        public int setNextTicketNumber()
        {
            return number + 1;
        }
    }
}
