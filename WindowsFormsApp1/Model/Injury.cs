using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Injury
    {

        [Key]
        public int Injury_id 
        {
            get;  set;
        }

        public string Injury_type
        {
            get;   set;
        }

        public virtual List<Patient_injury> Patient_Injuries { get; set; }

    }
}
