using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Patient
    {
        [Key]
        public int Patient_id
        {
            get;  set;
        }

        public string Patient_name
        {
            get;  set;
        }

        public int Patient_age
        {
            get;  set;
        }

        public string Patient_gender
        {
            get;  set;
        }

        public DateTime Patient_dob
        {
            get;  set;
        }

        public string Patient_address
        {
            get;  set;
        }

        public string Nic
        {
            get;  set;
        }

        public int Mobile
        {
            get;  set;
        }

        public string Email
        {
            get; set;
        }

        public string Weight
        {
            get;    set;
        }

        public string Health_issue
        {
            get;   set;
        }

        public DateTime Created_at
        {
            get;  set;
        }

        public DateTime Updated_at
        {
            get;  set;
        }

        

        public virtual Fasting_blood_sugar_test_report Fasting_Blood_Sugar_Test_Report { get; set; }

        public virtual Thyroxine_test_report Thyroxine_Test_Report { get; set; }

        public virtual Lipid_profile_test_report Lipid_Profile_Test_Report { get; set; }

        public virtual X_ray_scan_report X_Ray_Scan_Report { get; set; }

        public virtual CT_scan_report CT_Scan_Report { get; set; }

        
        public virtual List<Patient_illness> Patient_Illnesses { get; set; }

        public virtual List<Patient_injury> Patient_Injuries { get; set; }
     
       
        public virtual Surgery Surgery { get; set; }

        public virtual Custom_treatment_plan Custom_Treatment_Plan { get; set; }

        public virtual Room_admission Room_Admission { get; set; }

        public virtual Appointment_schedule Appointment_Schedule { get; set; }

    }
}
