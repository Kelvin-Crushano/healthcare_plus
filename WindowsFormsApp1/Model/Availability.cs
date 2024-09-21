using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Availability
    {
        [Key]
        public int Availability_id
        {
            get; set;
        }

        public DateTime Available_date
        {
            get; set;
        }

        public string Available_time_slot
        {
            get;   set;
        }


        public virtual List<Physician_availability> Physician_Availabilities { get; set; }


    }
}
