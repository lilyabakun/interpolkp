using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace interpolkp
{
    public class Blue_Circular 
    {
        [Required]
        public string charge { get; set; }
        [Required]
        public string info { get; set; }
        [Key]
        public int Blue_ID { get; set; }
        [Required]
        public int Circular__ID { get; set; }
        public virtual Circular Circular { get; set; }
    }
}
