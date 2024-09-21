using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Surgery_type
    {
          
         [Key]
         public int Surgery_type_id
        {
            get;   set;
        }

        public string Surgery_type_description
        {
            get;  set;
        }

        public float Surgery_cost
        {
            get;    set;
        }


        public virtual Surgery Surgery { get; set; }




             
    }
}
