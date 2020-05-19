using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace interpolkp
{
    public class Resualt_of_search
    {
        
        [Key]
        public int iD_Resualt { get; set; }

        public string date { get; set; }
        public int iD_Emploee { get; set; }

        public int iD_Circular { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Circular Circular { get; set; }
        
    }
}
