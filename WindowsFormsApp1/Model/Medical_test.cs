using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Medical_test
    {
        [Key]
        public int Medical_test_id
        {
            get;   set;
        }

        public string Medical_test_type
        {
            get;   set;
        }

        public float Medical_test_cost
        {
            get;   set;
        }


        public virtual Fasting_blood_sugar_test_report Fasting_Blood_Sugar_Test_Report { get; set; }

        public virtual Thyroxine_test_report Thyroxine_Test_Report { get; set; }

        public virtual Lipid_profile_test_report Lipid_Profile_Test_Report { get; set; }


    }
}
