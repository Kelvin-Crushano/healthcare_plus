using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Qualification
    {
        [Key]
        public int Qualification_id 
        {
            get; set;
        }

        public string Qualification_name
        {
            get;  set;
        }

        public string Qua_abbreviation
        {
            get;  set;
        }


        public virtual List <Physician_qualification> Physician_Qualifications { get; set; }




    }
}
