using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketProvider
{
    public partial class frmTickets : Form
    {

        List<TimeSlot> timeSlots = null;
        int currentTicketNumber;
        int guestsPerTimeSlot;
        TimeSlot currentTimeSlot;
        int currentTimeSlotIndex = 0;
        bool open = false;

        List<Ticket> tickets = new List<Ticket>();

        public frmTickets()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
            FormOptions frmOptions = new FormOptions();
            timeSlots = frmOptions.GetTimeSlots();
            currentTicketNumber = frmOptions.firstTicketNumber;
            guestsPerTimeSlot = frmOptions.guestsPerTimeSlot;

            updateFormText();

            if (!open) labelNextAvailableEntry.Text = timeSlots.First().start.ToShortTimeString();
            else if (open && currentTimeSlotIndex + 1 < timeSlots.Count)
            {
                labelNextAvailableEntry.Text = timeSlots[currentTimeSlotIndex + 1]
                       .start.ToShortTimeString();
            }
                
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            updateFormText();

            DateTime currentTime = DateTime.Now;
            for (int i = 0; i < timeSlots.Count; i++)
            {
                TimeSlot timeSlot = timeSlots[i];
                if (currentTime > timeSlot.start && currentTime < timeSlot.GetEndTime())
                {
                    currentTimeSlot = timeSlot;
                    currentTimeSlotIndex = i;
                    break;
                }

            }

            List<Ticket> currentTickets = new List<Ticket>();
            foreach (Ticket ticket in tickets.ToList())
            {
                if (ticket.timeSlot  == currentTimeSlot)
                {
                    currentTickets.Add(ticket);
                    
                    if (tickets.Count != 0)
                    {
                        tickets.RemoveAt(0);
                        listBoxTickets.Items.RemoveAt(0);
                    }
                    
                }
            }

            labelTotalTicketsOut.Text = listBoxTickets.Items.Count.ToString();

            //tickets being currently used - update label
            if (currentTickets.Count != 0)
            {
                int firstTicketNumber = currentTickets.First().number;
                int lastTicketNumber = currentTickets.Last().number;

                labelGuests.Text = firstTicketNumber.ToString() + " - " + lastTicketNumber.ToString();
            }

        }

        private void updateFormText()
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime > timeSlots.First().start && currentTime < timeSlots.Last().GetEndTime())
            {
                open = true;
                Text = currentTime.ToLongTimeString() + " (Open)";
            } 
            else
            {
                open = false;
                Text = currentTime.ToLongTimeString() + " (Closed)";
            }

            
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {

            DialogResult button = MessageBox.Show("Warning: All outstanding tickets will be deleted. " +
                    "Do you want to continue?", "Reset Tickets", MessageBoxButtons.YesNo);

            if (button == DialogResult.Yes)
            {
                timer.Stop();
                tickets.Clear();
                listBoxTickets.Items.Clear();
                currentTimeSlotIndex = 0;
                open = false;
                labelTotalTicketsOut.Text = "0";
                labelGuests.Text = "No tickets issued for time slot / Park closed.";

                FormOptions frmOptions = new FormOptions();
                timeSlots = frmOptions.GetTimeSlots();
                currentTicketNumber = frmOptions.firstTicketNumber;
                guestsPerTimeSlot = frmOptions.guestsPerTimeSlot;

                updateFormText();
                timer.Start();
            }
        }

        private void buttonIssueTicket_Click(object sender, EventArgs e)
        {
            //look for available time slots, starting from currentTimeSlot.next
            int nextTimeSlotIndex;

            if (!open) nextTimeSlotIndex = 0;
            else nextTimeSlotIndex = currentTimeSlotIndex + 1;

            for (int i = nextTimeSlotIndex; i < timeSlots.Count; i++)
            {
                if (timeSlots[i].tickets < guestsPerTimeSlot)
                {
                    Ticket newTicket = new Ticket(currentTicketNumber, timeSlots[i]);
                    timeSlots[i].tickets++;

                    tickets.Add(newTicket);
                    listBoxTickets.Items.Add("Ticket " + newTicket.number + ": " +
                        newTicket.timeSlot.start.ToShortTimeString());

                    currentTicketNumber = newTicket.setNextTicketNumber();
                    labelTotalTicketsOut.Text = listBoxTickets.Items.Count.ToString();

                    //update next available entry text
                    if (timeSlots[i].tickets < guestsPerTimeSlot)
                    {
                        labelNextAvailableEntry.Text = timeSlots[i].start.ToShortTimeString();
                    } else if (i + 1 < timeSlots.Count)
                    {
                        labelNextAvailableEntry.Text = timeSlots[i+1].start.ToShortTimeString();
                    }
                    break;
                }
            }
        }
    }
}
