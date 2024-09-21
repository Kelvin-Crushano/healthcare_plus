using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Operation_theatre
    {
        [Key]
        public int OT_id
        {
            get;   set;
        }

        public int OT_number
        {
            get;   set;
        }

        public DateTime OT_available_date
        {
            get;   set;
        }

        public string OT_available_status
        {
            get;    set;
        }

        public virtual Surgery Surgery { get; set; }


    }
}
