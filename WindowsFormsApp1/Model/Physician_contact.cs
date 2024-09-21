using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace HospitalProject.Model
{
    public class Physician_contact
    {
        [Key]
        public int Physician_contact_id { get; set; }

        public int Contact_no { get; set; }

        public int Physician_id { get; set; }

        public virtual Physician Physician { get; set; }

    }
}
