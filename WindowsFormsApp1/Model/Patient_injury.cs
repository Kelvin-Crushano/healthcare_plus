using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Patient_injury
    {
        public int Patient_injury_id
        {
            get;   set;
        }
        
        public int Patient_id
        {
            get;   set;
        }

        public int Injury_id
        {
            get;   set;
        }

        public virtual Patient Patient { get; set; }

        public virtual Injury Injury { get; set; }


    }
}
