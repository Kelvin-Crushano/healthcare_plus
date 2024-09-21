using HospitalProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_admin_dashboard : Form
    {
        public frm_admin_dashboard()
        {
            InitializeComponent();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appointmentChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void physicianProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void physicianQualificationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void physicianContactToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void academicQualificationsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
           
        }

        private void physicianAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void hospitalConsulataionHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void appointmentSchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frm_consul_appo_sched frm_Consul_Appo_Sched = new frm_consul_appo_sched();
            frm_Consul_Appo_Sched.Show();
        }

        private void patientProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frm_patient_profile frm_Patient_Profile = new frm_patient_profile();
            frm_Patient_Profile.Show();
        }

        private void patientMedicalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frm_patient_med_record frm_Patient_Med_Record = new frm_patient_med_record();
            frm_Patient_Med_Record.Show();
        }

        private void scheduleSurgeryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // this.Hide();
            frm_schedule_surgery frm_Schedule_Surgery = new frm_schedule_surgery();
            frm_Schedule_Surgery.Show();
        }

        private void operationTheatersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frm_theater_availability frm_Theater_Availability = new frm_theater_availability();
            frm_Theater_Availability.Show();
        }

        private void availableSurgeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
           
        }

        private void roomSchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frm_room_scheduling frm_Room_Scheduling = new frm_room_scheduling();
            frm_Room_Scheduling.Show();
        }

        private void availableRoomFacilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            
        }

        private void medicalResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frm_medical_resources frm_Medical_Resources = new frm_medical_resources();
            frm_Medical_Resources.Show();

        }

        private void medicalReportChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void imagingStudiesChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void medicineChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void patientBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userAccoountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_user_accounts frm_User_Accounts = new frm_user_accounts();
            frm_User_Accounts.Show();
        }

        private void staffRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_st_registration frm_St_Registration = new frm_st_registration();
            frm_St_Registration.Show();
        }

        private void jobRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void frm_admin_dashboard_Load(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
        }

        private void patientRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patiant fm = new patiant();
            panel1.Controls.Clear();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void sheduleAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consul_appo_sched fm = new frm_consul_appo_sched();
            panel1.Controls.Clear();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void doctorsDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctors_detailes fm = new doctors_detailes();
            panel1.Controls.Clear();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void viewDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_medical_resources fm = new frm_medical_resources();
            panel1.Controls.Clear();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_custom_treatment_plan fm = new frm_custom_treatment_plan();
            panel1.Controls.Clear();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void medicationTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicine_detailes fm = new medicine_detailes();
            panel1.Controls.Clear();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void roomAndAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_room_scheduling fm = new frm_room_scheduling();
            panel1.Controls.Clear();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void theaterAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_theater_availability fm = new frm_theater_availability();
            panel1.Controls.Clear();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice fm = new Invoice();
            panel1.Controls.Clear();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void roomsAndAmontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            room_with_amnt fm = new room_with_amnt();
            panel1.Controls.Clear();
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}
