using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Lipid_profile_test_report
    {
        [Key]
        public int Lp_test_report_id
        {
            get;  set;
        }
        public int Cholestrol
        {
            get;   set;
        }

        public int Triglyceride
        {
            get;    set;
        }

        public int Cholestrol_HDL 
        {
            get;   set;
        }

        public int Cholestrol_LDL 
        {
            get;   set;
        }

        public int VLDL_cholestrol
        {
            get;    set;
        }

        public int Non_HDL_cholestrol
        {
            get;   set;
        }

        public string Reference_range
        {
            get;   set;
        }

        public DateTime Sample_collected
        {
            get;  set;
        }

        public DateTime Created_at
        {
            get;  set;
        }

        public DateTime Updated_at
        {
            get;   set;
        }


        public int Patient_id
        {
            get;   set;
        }


        public int Medical_test_id
        {
            get;    set;
        }


        public virtual Patient Patient { get; set; }

        public virtual Medical_test Medical_Test { get; set; }


    }
}
