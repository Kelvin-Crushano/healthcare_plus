using HospitalProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Physician
    {
        [Key]
        public int Physician_id
        {
            get;  set;
        }

        public string Dr_reg_no
        {
            get;  set;
        }

        public string Dr_first_name
        {
            get;   set;
        }

        public string Dr_last_name
        {
            get;  set;
        }

        public virtual List<Physician_contact> Physician_Contacts
        {
            get; set;
        }

        public virtual List<Physician_availability> Physician_Availabilities
        {
            get; set;
        }

        public virtual List<Physician_qualification> Physician_Qualifications
        {
            get; set;
        }



    }
}
