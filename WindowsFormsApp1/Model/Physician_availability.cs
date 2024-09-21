using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Physician_availability
    {
        [Key]
        public int Pa_id
        {
            get;    set;
        }

        public int Physician_id
        {
            get;    set;
        }

        public int Availability_id
        {
            get;    set;
        }


        public virtual Physician Physician { get; set; }

        public virtual Availability Availability { get; set; }


        public virtual List<Appointment_schedule> Appointment_Schedules { get; set; }




    }
}
