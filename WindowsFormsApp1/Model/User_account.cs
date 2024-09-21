using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class User_account
    {
        [Key]
        public int User_acc_id
        {
            get;   set;
        }

        public string User_name
        {
            get;    set;
        }

        public string User_password
        {
            get;    set;
        }

        public int Staff_id
        {
            get; set;
        }



        public virtual Staff Staff { get; set; }
        

    }
}
