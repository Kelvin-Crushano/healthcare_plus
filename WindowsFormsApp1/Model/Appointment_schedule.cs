using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Appointment_schedule
    {

        [Key]
        public int Appointment_id
        {
            get;  set;
        }

        public DateTime Created_at
        {
            get; set;
        }

        public int Pa_id
        {
            get;  set;
        }

        public int Patient_id
        {
            get;  set;
        }


        public virtual Physician_availability Physician_Availability { get; set; }

        public virtual Patient Patient { get; set; }



    }
}
