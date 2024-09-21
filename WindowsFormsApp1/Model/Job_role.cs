using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Job_role
    {
        [Key]
        public int Job_role_id
        {
            get;  set; 
        }

        public string Job_role_name
        {
            get;  set;
        }

        public virtual List<Staff> Staffs { get; set; } 

    }
}
