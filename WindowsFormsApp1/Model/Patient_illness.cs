using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Patient_illness
    {
       [Key]
       public int Patient_illness_id
        {
            get;    set;
        }

        public  int Patient_id
        {
            get;    set;
        }

        public int Illness_id
        {
            get;    set;
        }

        public virtual Patient Patient { get; set; }

        public virtual Illness Illness { get; set; }




    }
}
