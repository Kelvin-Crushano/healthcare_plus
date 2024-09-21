using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Custom_treatment_plan
    {
        [Key]
        public int Custom_treatment_plan_id
        {
            get;    set;
        }

        public string Frequency
        {
            get;        set;
        }

        public string Duration
        {
            get;   set;
        }

        public string Special_instructions
        {
            get;    set;
        }

        public DateTime Created_at
        {
            get;    set;
        }

        public DateTime Updated_at
        {
            get;    set;
        }

        public int Patient_id
        {
            get;   set;
        }

        public int medication_id 
        { 
            get;    set; 
        }

        public virtual Patient Patient { get; set; }

        public virtual Medication_price Medication_Price { get; set; }

    }
}
