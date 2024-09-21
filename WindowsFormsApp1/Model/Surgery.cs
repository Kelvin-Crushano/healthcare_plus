using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Surgery
    {
         [Key]
         public int Surgery_id
        {
            get;    set;
        }

        public DateTime Surgery_date
        {
            get;    set;
        }

        public DateTime Surgery_time
        {
            get;     set;
        }

        public int Surgery_type_id
        {
            get;   set;
        }

        public int Patient_id
        {
            get;    set;
        }

        public int OT_id
        {
            get;    set;
        }

        public virtual Patient Patient { get; set; }

        public virtual Surgery_type Surgery_Type { get; set; }

        public virtual Operation_theatre Operation_Theatre { get; set; }


    }
}
