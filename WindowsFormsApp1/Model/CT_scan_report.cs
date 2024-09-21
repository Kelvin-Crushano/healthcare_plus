using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class CT_scan_report
    {
        [Key]
        public int CT_scan_report_id
        {
            get;   set;
        }

        public string Examination_description
        {
            get;    set;
        }

        public DateTime Scan_performed
        {
            get;    set;
        }


        public  DateTime Created_at
        {
            get;   set;
        }

        public DateTime Updated_at
        {
            get;    set;
        }

        public int Patient_id
        {
            get;     set;
        }

        public int Is_id
        {
            get;    set;
        }

        public int Mr_id
        {
            get;    set;
        }

        public virtual Patient Patient { get; set; }

        public virtual Imaging_studies_list Imaging_Studies_List { get; set; }

        public virtual Medical_resources Medical_Resources { get; set; }




    }
}
