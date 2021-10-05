
namespace Runway_Hair_Salon
{
    partial class Schedule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRoom = new System.Windows.Forms.ListBox();
            this.lbTreatment = new System.Windows.Forms.ListBox();
            this.lbCustomer = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvAppointments = new System.Windows.Forms.ListView();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rtbBookingDate = new System.Windows.Forms.RichTextBox();
            this.rtbCustomerNo = new System.Windows.Forms.RichTextBox();
            this.rtbCustomerInfo = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbRoom);
            this.panel1.Controls.Add(this.lbTreatment);
            this.panel1.Controls.Add(this.lbCustomer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 185);
            this.panel1.TabIndex = 0;
            // 
            // lbRoom
            // 
            this.lbRoom.FormattingEnabled = true;
            this.lbRoom.Location = new System.Drawing.Point(647, 40);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(298, 134);
            this.lbRoom.TabIndex = 2;
            // 
            // lbTreatment
            // 
            this.lbTreatment.FormattingEnabled = true;
            this.lbTreatment.Location = new System.Drawing.Point(329, 40);
            this.lbTreatment.Name = "lbTreatment";
            this.lbTreatment.Size = new System.Drawing.Size(298, 134);
            this.lbTreatment.TabIndex = 2;
            // 
            // lbCustomer
            // 
            this.lbCustomer.FormattingEnabled = true;
            this.lbCustomer.Location = new System.Drawing.Point(12, 40);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(298, 134);
            this.lbCustomer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(642, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(324, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Treatment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lvAppointments);
            this.panel2.Controls.Add(this.pnlDateTime);
            this.panel2.Controls.Add(this.rtbBookingDate);
            this.panel2.Controls.Add(this.rtbCustomerNo);
            this.panel2.Controls.Add(this.rtbCustomerInfo);
            this.panel2.Location = new System.Drawing.Point(12, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 285);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(711, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove Appointment";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(711, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Appointment";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lvAppointments
            // 
            this.lvAppointments.HideSelection = false;
            this.lvAppointments.Location = new System.Drawing.Point(329, 172);
            this.lvAppointments.Name = "lvAppointments";
            this.lvAppointments.Size = new System.Drawing.Size(376, 110);
            this.lvAppointments.TabIndex = 2;
            this.lvAppointments.UseCompatibleStateImageBehavior = false;
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.BackColor = System.Drawing.Color.White;
            this.pnlDateTime.Controls.Add(this.label5);
            this.pnlDateTime.Controls.Add(this.label4);
            this.pnlDateTime.Controls.Add(this.comboBox1);
            this.pnlDateTime.Controls.Add(this.dateTimePicker1);
            this.pnlDateTime.Location = new System.Drawing.Point(329, 65);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(616, 100);
            this.pnlDateTime.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Appointment Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Appointment Date";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(392, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(392, 30);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // rtbBookingDate
            // 
            this.rtbBookingDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbBookingDate.Location = new System.Drawing.Point(329, 21);
            this.rtbBookingDate.Name = "rtbBookingDate";
            this.rtbBookingDate.Size = new System.Drawing.Size(616, 38);
            this.rtbBookingDate.TabIndex = 0;
            this.rtbBookingDate.Text = "";
            // 
            // rtbCustomerNo
            // 
            this.rtbCustomerNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCustomerNo.Location = new System.Drawing.Point(12, 21);
            this.rtbCustomerNo.Name = "rtbCustomerNo";
            this.rtbCustomerNo.Size = new System.Drawing.Size(298, 38);
            this.rtbCustomerNo.TabIndex = 0;
            this.rtbCustomerNo.Text = "";
            // 
            // rtbCustomerInfo
            // 
            this.rtbCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCustomerInfo.Location = new System.Drawing.Point(12, 65);
            this.rtbCustomerInfo.Name = "rtbCustomerInfo";
            this.rtbCustomerInfo.Size = new System.Drawing.Size(298, 217);
            this.rtbCustomerInfo.TabIndex = 0;
            this.rtbCustomerInfo.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Runway_Hair_Salon.Properties.Resources.Run_Way_Beauty_Salon_Header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 98);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Runway_Hair_Salon.Properties.Resources.White_and_Gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlDateTime.ResumeLayout(false);
            this.pnlDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbRoom;
        private System.Windows.Forms.ListBox lbTreatment;
        private System.Windows.Forms.ListBox lbCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvAppointments;
        private System.Windows.Forms.Panel pnlDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox rtbBookingDate;
        private System.Windows.Forms.RichTextBox rtbCustomerNo;
        private System.Windows.Forms.RichTextBox rtbCustomerInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errP;
    }
}

