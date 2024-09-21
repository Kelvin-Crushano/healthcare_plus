using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Imaging_studies_list
    {
        [Key]
        public int Is_id
        {
            get;  set;
        }

        public string Imaging_type
        {
            get;   set;
        }

        public float Imaging_cost
        {
            get;   set;
        }

        public virtual X_ray_scan_report X_Ray_Scan_Report { get; set; }

        public virtual CT_scan_report CT_Scan_Report { get; set; }


    }
}
