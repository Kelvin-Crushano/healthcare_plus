using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Medication_price
    {
        [Key]
        public int Medication_id
        {
            get;    set;
        }

        public string Medication_type
        {
            get;   set;
        }

        public string Dosage
        {
            get;   set;
        }

        public float Medicine_price
        {
            get;   set;
        }

        public virtual List<Custom_treatment_plan> Custom_Treatment_Plans { get; set; }


    }
}
