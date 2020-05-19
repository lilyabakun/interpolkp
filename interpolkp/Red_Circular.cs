using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace interpolkp
{
    public class Red_Circular 
    {
        [Key]
        public int red_ID { get; set; }
        public string charge { get; set; }
        public string info { get; set; }
        public int Circular__ID { get; set; }
        public virtual Circular Circular { get; set; }





    }
}
