using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Room_facility
    {
        [Key]
        public int Room_facility_id
        {
            get;     set;
        }

        public string Room_type
        {
            get;   set;
        }

        public int Room_number
        {
            get;    set;
        }

        public DateTime Available_date
        {
            get;    set;
        }

        public float Room_cost_per_day
        {
            get;    set;
        }


        public virtual Room_admission Room_Admission { get; set; }
        

    }
}
