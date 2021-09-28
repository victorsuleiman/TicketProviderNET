
namespace TicketProvider
{
    partial class FormOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMinsPerWindow = new System.Windows.Forms.TextBox();
            this.textBoxGuestsPerWindow = new System.Windows.Forms.TextBox();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.textBoxFIrstTckNumber = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guests per window:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "End time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "First ticket number:";
            // 
            // textBoxMinsPerWindow
            // 
            this.textBoxMinsPerWindow.Location = new System.Drawing.Point(184, 38);
            this.textBoxMinsPerWindow.Name = "textBoxMinsPerWindow";
            this.textBoxMinsPerWindow.Size = new System.Drawing.Size(146, 22);
            this.textBoxMinsPerWindow.TabIndex = 5;
            this.textBoxMinsPerWindow.Text = "5";
            // 
            // textBoxGuestsPerWindow
            // 
            this.textBoxGuestsPerWindow.Location = new System.Drawing.Point(184, 82);
            this.textBoxGuestsPerWindow.Name = "textBoxGuestsPerWindow";
            this.textBoxGuestsPerWindow.Size = new System.Drawing.Size(146, 22);
            this.textBoxGuestsPerWindow.TabIndex = 6;
            this.textBoxGuestsPerWindow.Text = "5";
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(184, 127);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(146, 22);
            this.textBoxStartTime.TabIndex = 7;
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(184, 174);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(146, 22);
            this.textBoxEndTime.TabIndex = 8;
            // 
            // textBoxFIrstTckNumber
            // 
            this.textBoxFIrstTckNumber.Location = new System.Drawing.Point(184, 219);
            this.textBoxFIrstTckNumber.Name = "textBoxFIrstTckNumber";
            this.textBoxFIrstTckNumber.Size = new System.Drawing.Size(146, 22);
            this.textBoxFIrstTckNumber.TabIndex = 9;
            this.textBoxFIrstTckNumber.Text = "1";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(184, 257);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(146, 34);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormOptions
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 331);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxFIrstTckNumber);
            this.Controls.Add(this.textBoxEndTime);
            this.Controls.Add(this.textBoxStartTime);
            this.Controls.Add(this.textBoxGuestsPerWindow);
            this.Controls.Add(this.textBoxMinsPerWindow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOptions";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMinsPerWindow;
        private System.Windows.Forms.TextBox textBoxGuestsPerWindow;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.TextBox textBoxFIrstTckNumber;
        private System.Windows.Forms.Button buttonOK;
    }
}