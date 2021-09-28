
namespace TicketProvider
{
    partial class frmTickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxGuests = new System.Windows.Forms.GroupBox();
            this.labelGuests = new System.Windows.Forms.Label();
            this.groupBoxTickets = new System.Windows.Forms.GroupBox();
            this.buttonIssueTicket = new System.Windows.Forms.Button();
            this.labelNextAvailableEntry = new System.Windows.Forms.Label();
            this.labelTotalTicketsOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTickets = new System.Windows.Forms.ListBox();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxGuests.SuspendLayout();
            this.groupBoxTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGuests
            // 
            this.groupBoxGuests.Controls.Add(this.labelGuests);
            this.groupBoxGuests.Location = new System.Drawing.Point(24, 34);
            this.groupBoxGuests.Name = "groupBoxGuests";
            this.groupBoxGuests.Size = new System.Drawing.Size(411, 69);
            this.groupBoxGuests.TabIndex = 0;
            this.groupBoxGuests.TabStop = false;
            this.groupBoxGuests.Text = "Guests with the following tickets may now enter:";
            // 
            // labelGuests
            // 
            this.labelGuests.AutoSize = true;
            this.labelGuests.Location = new System.Drawing.Point(23, 32);
            this.labelGuests.Name = "labelGuests";
            this.labelGuests.Size = new System.Drawing.Size(282, 17);
            this.labelGuests.TabIndex = 0;
            this.labelGuests.Text = "No tickets issued for time slot / Park closed.";
            // 
            // groupBoxTickets
            // 
            this.groupBoxTickets.Controls.Add(this.buttonIssueTicket);
            this.groupBoxTickets.Controls.Add(this.labelNextAvailableEntry);
            this.groupBoxTickets.Controls.Add(this.labelTotalTicketsOut);
            this.groupBoxTickets.Controls.Add(this.label1);
            this.groupBoxTickets.Controls.Add(this.label2);
            this.groupBoxTickets.Location = new System.Drawing.Point(24, 127);
            this.groupBoxTickets.Name = "groupBoxTickets";
            this.groupBoxTickets.Size = new System.Drawing.Size(411, 136);
            this.groupBoxTickets.TabIndex = 1;
            this.groupBoxTickets.TabStop = false;
            this.groupBoxTickets.Text = "Ticket Availability";
            // 
            // buttonIssueTicket
            // 
            this.buttonIssueTicket.Location = new System.Drawing.Point(26, 95);
            this.buttonIssueTicket.Name = "buttonIssueTicket";
            this.buttonIssueTicket.Size = new System.Drawing.Size(143, 27);
            this.buttonIssueTicket.TabIndex = 4;
            this.buttonIssueTicket.Text = "Issue Ticket";
            this.buttonIssueTicket.UseVisualStyleBackColor = true;
            this.buttonIssueTicket.Click += new System.EventHandler(this.buttonIssueTicket_Click);
            // 
            // labelNextAvailableEntry
            // 
            this.labelNextAvailableEntry.AutoSize = true;
            this.labelNextAvailableEntry.Location = new System.Drawing.Point(248, 64);
            this.labelNextAvailableEntry.Name = "labelNextAvailableEntry";
            this.labelNextAvailableEntry.Size = new System.Drawing.Size(35, 17);
            this.labelNextAvailableEntry.TabIndex = 3;
            this.labelNextAvailableEntry.Text = "TBA";
            // 
            // labelTotalTicketsOut
            // 
            this.labelTotalTicketsOut.AutoSize = true;
            this.labelTotalTicketsOut.Location = new System.Drawing.Point(248, 32);
            this.labelTotalTicketsOut.Name = "labelTotalTicketsOut";
            this.labelTotalTicketsOut.Size = new System.Drawing.Size(16, 17);
            this.labelTotalTicketsOut.TabIndex = 2;
            this.labelTotalTicketsOut.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Next available entry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Tickets outstanding:";
            // 
            // listBoxTickets
            // 
            this.listBoxTickets.FormattingEnabled = true;
            this.listBoxTickets.ItemHeight = 16;
            this.listBoxTickets.Location = new System.Drawing.Point(24, 282);
            this.listBoxTickets.Name = "listBoxTickets";
            this.listBoxTickets.Size = new System.Drawing.Size(411, 164);
            this.listBoxTickets.TabIndex = 2;
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(24, 467);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(104, 32);
            this.buttonOptions.TabIndex = 3;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(331, 467);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(104, 32);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmTickets
            // 
            this.AcceptButton = this.buttonIssueTicket;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 522);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.listBoxTickets);
            this.Controls.Add(this.groupBoxTickets);
            this.Controls.Add(this.groupBoxGuests);
            this.Name = "frmTickets";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTickets_Load);
            this.groupBoxGuests.ResumeLayout(false);
            this.groupBoxGuests.PerformLayout();
            this.groupBoxTickets.ResumeLayout(false);
            this.groupBoxTickets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGuests;
        private System.Windows.Forms.Label labelGuests;
        private System.Windows.Forms.GroupBox groupBoxTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIssueTicket;
        private System.Windows.Forms.Label labelNextAvailableEntry;
        private System.Windows.Forms.Label labelTotalTicketsOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTickets;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer;
    }
}

