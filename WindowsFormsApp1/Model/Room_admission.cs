using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Room_admission
    {

        [Key]
         public int Room_occupied_id
        {
            get;     set;
        }

        public DateTime Admission_date
        {
            get;   set;
        }


        public DateTime Discharge_date
        {
            get;    set;
        }

        public DateTime Created_at
        {
            get;   set;
        }

        public  DateTime Updated_at
        {
            get;   set;
        }


        public int Patient_id
        {
            get;   set;
        }

        public int Room_facility_id
        {
            get;   set;
        }

        


        public virtual Patient Patient { get; set; }

        public virtual Room_facility Room_Facility { get; set; }



    }
}
