using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Illness
    {
        [Key]
        public int Illness_id
        {
            get;  set;
        }

        public string Illness_type
        {
            get;  set;
        }

        public virtual List<Patient_illness> Patient_Illnesses { get; set; }
       
    }
}
