using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketProvider
{
    public class TimeSlot
    {
        public DateTime start;
        public double length;
        public int tickets;

        public TimeSlot(DateTime start, double length, int tickets)
        {
            this.start = start;
            this.length = length;
            this.tickets = tickets;
        }

        public DateTime GetEndTime()
        {
            return start.AddMinutes(length);
        }
    }
}
