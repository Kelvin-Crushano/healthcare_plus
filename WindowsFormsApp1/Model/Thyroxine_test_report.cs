using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Thyroxine_test_report
    {
       [Key]
       public int Thyroxine_test_report_id
        {
            get;  set;
        }

        public float Thyroxine_FT4
        {
            get;  set;
        }

        public string Reference_range
        {
            get;  set;
        }

        public string Comment
        {
            get;   set;
        }

        public DateTime Sample_collected
        {
            get;   set;
        }

        public DateTime Created_at
        {
            get;    set;
        }

        public DateTime Updated_at
        {
            get;     set;
        }

        public int Patient_id
        {
            get;    set;
        }

        public int Medical_test_id
        {
            get;   set;
        }


        public virtual Patient Patient { get; set; }

        public virtual Medical_test Medical_Test { get; set; }
    }
}
