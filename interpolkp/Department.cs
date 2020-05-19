using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace interpolkp
{
    public class Department
    {
        public Department(string country, string adress, int phone, int number, int iD_Department)
        {
            this.country = country;
            this.adress = adress;
            this.phone = phone;
            this.number = number;
            ID_Department = iD_Department;
        }

        [Required]
        public string country { get; set; }
        [Required]
        public string adress { get; set; }
        [Required]
        public int phone { get; set; }
        [Required]
        public int number { get; set; }
        [Key]
        public int ID_Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public Department()
        {
            Employees = new List<Employee>();
        }
        /*public virtual ICollection<Player> Players { get; set; }
 
    public Team()
    {
        Players = new List<Player>();
    }*/


    }
}
