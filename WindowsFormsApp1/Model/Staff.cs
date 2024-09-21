using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Staff
    {
        [Key]
        public int Staff_id
        {
            get;  set;
        }

        public string First_name
        {
            get;  set;
        }

        public string Last_name
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public string Nic
        {
            get; set;
        }

        public int Job_Role_Id { get; set; }

        //public virtual List<User_account> userAccount { get; set; }//Many
        public virtual User_account User_Account { get; set; }
        public virtual Job_role Job_Role { get; set; }
         
    }
}
