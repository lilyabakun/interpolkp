using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace interpolkp
{
    public class Black_Circular 
    {
        

        [Key]
        public int black_ID { get => black_ID; set => black_ID = value; }
        
        public string place { get; set; }
        
        public string deathCause { get; set; }
        public int Circular__ID { get; set; }
        public virtual Circular Circular { get; set; }


       
       
    }
}
