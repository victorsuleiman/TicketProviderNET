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
    public partial class FormOptions : Form
    {

        public List<TimeSlot> timeSlots = new List<TimeSlot>();
        public int firstTicketNumber;
        public int guestsPerTimeSlot;

        public FormOptions()
        {
            InitializeComponent();
        }

        public void SetDefaultTimes()
        {
            textBoxStartTime.Text = DateTime.Now.ToShortTimeString();
            textBoxEndTime.Text = DateTime.Now.AddHours(4).ToShortTimeString();
        }

        public List<TimeSlot> GetTimeSlots()
        {
            SetDefaultTimes();
            this.ShowDialog();
            return timeSlots;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                generateTimeSlots();
                if (timeSlots.Count >= 2)
                    this.Close();
                else
                    MessageBox.Show("Error: the difference between the start and the " +
                        "end times must generate at least two time slots.");
            }
                
        }

        private bool validateInputs()
        {

            string message = "";

            if (!int.TryParse(textBoxMinsPerWindow.Text, out _))
                message += "Minutes per window must be an integer number.\n";
            if (!int.TryParse(textBoxGuestsPerWindow.Text, out _))
                message += "Guests per window must be an integer number.\n";
            if (!int.TryParse(textBoxFIrstTckNumber.Text, out _))
                message += "First ticket number must be an integer number.\n";
            if (!DateTime.TryParse(textBoxStartTime.Text, out _))
                message += "Start Time must be a DateTime value.\n";
            if (!DateTime.TryParse(textBoxEndTime.Text, out _))
                message += "End Time must be a DateTime value.";

            if (message == "") return true;
            else
            {
                MessageBox.Show("Error:\n" + message);
                return false;
            }

        }

        private void generateTimeSlots()
        {
            int minutesPerWindow = int.Parse(textBoxMinsPerWindow.Text);
            guestsPerTimeSlot = int.Parse(textBoxGuestsPerWindow.Text);
            DateTime startTime = DateTime.Parse(textBoxStartTime.Text);
            DateTime endTime = DateTime.Parse(textBoxEndTime.Text);

            firstTicketNumber = int.Parse(textBoxFIrstTckNumber.Text);

            DateTime currentTime = startTime;

            while (currentTime < endTime)
            {
                timeSlots.Add(new TimeSlot(currentTime, minutesPerWindow, 0));
                currentTime = currentTime.AddMinutes(minutesPerWindow);
            }
        }
    }
}
