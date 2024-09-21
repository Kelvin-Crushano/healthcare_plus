using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Physician_qualification
    {
        [Key]
        public int Phy_qua_id
        {
            get; set;
        }

        public int Year
        {
            get;  set;
        }

        public int Physician_id 
        {
            get; set; 
        }

        public int Qualification_id
        {
            get;    set;
        }



        public virtual Physician Physician { get; set; }

        public virtual Qualification Qualification { get; set; }

        
       

    }
}
