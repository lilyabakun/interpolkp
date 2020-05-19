using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpolkp
{
    public class Employee
    {
        
        [Key]
        public int iD_Employee { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public int? phone { get; set; }
        public int iD_Department { get; set; }
        public virtual Department departments { get; set; }


    }
}
