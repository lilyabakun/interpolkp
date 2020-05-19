using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace interpolkp
{
    public class Yellow_circular 
    {
        
        [Key]
        public int yellow_ID { get; set; }
        public string motherName { get; set; }
        public string fatherName { get; set; }
        public string dateMiss { get; set; }
        public string placeMiss { get; set; }
        public int Circular__ID { get; set; }
        public virtual Circular Circular { get; set; }


    }
}
