
using System;

namespace WindowsFormsApp1
{
    partial class frm_admin_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin_dashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appointmentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sheduleAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientRecordsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsRecordsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsDetailesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthcareResourcesAndInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicationTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomAndTheaterAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomAndAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theaterAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsAndAmontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 437);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(363, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "HEALTHCARE PLUS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentManagementToolStripMenuItem,
            this.patientRecordsManagementToolStripMenuItem,
            this.doctorsRecordsManagementToolStripMenuItem,
            this.healthcareResourcesAndInformationToolStripMenuItem,
            this.medicationManagementToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.roomAndTheaterAvailabilityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1240, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // appointmentManagementToolStripMenuItem
            // 
            this.appointmentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sheduleAppointmentToolStripMenuItem});
            this.appointmentManagementToolStripMenuItem.Name = "appointmentManagementToolStripMenuItem";
            this.appointmentManagementToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.appointmentManagementToolStripMenuItem.Text = "Appointment Management";
            // 
            // sheduleAppointmentToolStripMenuItem
            // 
            this.sheduleAppointmentToolStripMenuItem.Name = "sheduleAppointmentToolStripMenuItem";
            this.sheduleAppointmentToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sheduleAppointmentToolStripMenuItem.Text = "Shedule Appointment";
            this.sheduleAppointmentToolStripMenuItem.Click += new System.EventHandler(this.sheduleAppointmentToolStripMenuItem_Click);
            // 
            // patientRecordsManagementToolStripMenuItem
            // 
            this.patientRecordsManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientRecordsToolStripMenuItem});
            this.patientRecordsManagementToolStripMenuItem.Name = "patientRecordsManagementToolStripMenuItem";
            this.patientRecordsManagementToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.patientRecordsManagementToolStripMenuItem.Text = "Patient Records Management";
            // 
            // patientRecordsToolStripMenuItem
            // 
            this.patientRecordsToolStripMenuItem.Name = "patientRecordsToolStripMenuItem";
            this.patientRecordsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.patientRecordsToolStripMenuItem.Text = "Patient Records";
            this.patientRecordsToolStripMenuItem.Click += new System.EventHandler(this.patientRecordsToolStripMenuItem_Click);
            // 
            // doctorsRecordsManagementToolStripMenuItem
            // 
            this.doctorsRecordsManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsDetailesToolStripMenuItem});
            this.doctorsRecordsManagementToolStripMenuItem.Name = "doctorsRecordsManagementToolStripMenuItem";
            this.doctorsRecordsManagementToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.doctorsRecordsManagementToolStripMenuItem.Text = "Doctors Management";
            // 
            // doctorsDetailesToolStripMenuItem
            // 
            this.doctorsDetailesToolStripMenuItem.Name = "doctorsDetailesToolStripMenuItem";
            this.doctorsDetailesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.doctorsDetailesToolStripMenuItem.Text = "Doctors Records";
            this.doctorsDetailesToolStripMenuItem.Click += new System.EventHandler(this.doctorsDetailesToolStripMenuItem_Click);
            // 
            // healthcareResourcesAndInformationToolStripMenuItem
            // 
            this.healthcareResourcesAndInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailesToolStripMenuItem});
            this.healthcareResourcesAndInformationToolStripMenuItem.Name = "healthcareResourcesAndInformationToolStripMenuItem";
            this.healthcareResourcesAndInformationToolStripMenuItem.Size = new System.Drawing.Size(221, 20);
            this.healthcareResourcesAndInformationToolStripMenuItem.Text = "Healthcare Resources and Information";
            // 
            // viewDetailesToolStripMenuItem
            // 
            this.viewDetailesToolStripMenuItem.Name = "viewDetailesToolStripMenuItem";
            this.viewDetailesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.viewDetailesToolStripMenuItem.Text = "View Detailes";
            this.viewDetailesToolStripMenuItem.Click += new System.EventHandler(this.viewDetailesToolStripMenuItem_Click);
            // 
            // medicationManagementToolStripMenuItem
            // 
            this.medicationManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.medicationTrackingToolStripMenuItem});
            this.medicationManagementToolStripMenuItem.Name = "medicationManagementToolStripMenuItem";
            this.medicationManagementToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.medicationManagementToolStripMenuItem.Text = "Medication Management";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.viewToolStripMenuItem.Text = "Patient Medication Schedules";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // medicationTrackingToolStripMenuItem
            // 
            this.medicationTrackingToolStripMenuItem.Name = "medicationTrackingToolStripMenuItem";
            this.medicationTrackingToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.medicationTrackingToolStripMenuItem.Text = "Medication Tracking";
            this.medicationTrackingToolStripMenuItem.Click += new System.EventHandler(this.medicationTrackingToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // roomAndTheaterAvailabilityToolStripMenuItem
            // 
            this.roomAndTheaterAvailabilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomAndAvailabilityToolStripMenuItem,
            this.theaterAvailabilityToolStripMenuItem,
            this.roomsAndAmontToolStripMenuItem});
            this.roomAndTheaterAvailabilityToolStripMenuItem.Name = "roomAndTheaterAvailabilityToolStripMenuItem";
            this.roomAndTheaterAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(177, 20);
            this.roomAndTheaterAvailabilityToolStripMenuItem.Text = "Room and Theater Availability";
            // 
            // roomAndAvailabilityToolStripMenuItem
            // 
            this.roomAndAvailabilityToolStripMenuItem.Name = "roomAndAvailabilityToolStripMenuItem";
            this.roomAndAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.roomAndAvailabilityToolStripMenuItem.Text = "Room and Availability";
            this.roomAndAvailabilityToolStripMenuItem.Click += new System.EventHandler(this.roomAndAvailabilityToolStripMenuItem_Click);
            // 
            // theaterAvailabilityToolStripMenuItem
            // 
            this.theaterAvailabilityToolStripMenuItem.Name = "theaterAvailabilityToolStripMenuItem";
            this.theaterAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.theaterAvailabilityToolStripMenuItem.Text = "Theater Availability";
            this.theaterAvailabilityToolStripMenuItem.Click += new System.EventHandler(this.theaterAvailabilityToolStripMenuItem_Click);
            // 
            // roomsAndAmontToolStripMenuItem
            // 
            this.roomsAndAmontToolStripMenuItem.Name = "roomsAndAmontToolStripMenuItem";
            this.roomsAndAmontToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.roomsAndAmontToolStripMenuItem.Text = "Room Charges";
            this.roomsAndAmontToolStripMenuItem.Click += new System.EventHandler(this.roomsAndAmontToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1147, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_admin_dashboard";
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_admin_dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /*private void physicianProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }   */

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appointmentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sheduleAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientRecordsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsRecordsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsDetailesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthcareResourcesAndInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicationTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomAndTheaterAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomAndAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theaterAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsAndAmontToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}