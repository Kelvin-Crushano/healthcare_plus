using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Medical_resources
    {
        [Key]
        public int Mr_id
        {
            get;  set;
        }

        public string Equipment_type
        {
            get;  set;
        }

        public string Manufacturer
        {
            get;  set;
        }

        public string Model
        {
            get;  set;
        }

        public int Serial_no
        {
            get;     set;
        }

        public virtual X_ray_scan_report X_Ray_Scan_Report { get; set; }

        public virtual CT_scan_report CT_Scan_Report { get; set; }


    }
}
