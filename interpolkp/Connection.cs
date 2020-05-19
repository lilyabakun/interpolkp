using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace interpolkp
{
    public class Connection : DbContext
    {
        public Connection() : base("DefaultConnection")
        {

        }

        

        public DbSet<Department> Departments { get; set ; }


        public DbSet<Resualt_of_search> Resualts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Circular> Circulars { get; set; }
        public DbSet<Red_Circular> Reds { get; set; }
        public DbSet<Blue_Circular> Blues { get; set; }
        public DbSet<Black_Circular> Blacks { get; set; }
        public DbSet<Yellow_circular> Yellows { get; set; }
        public DbSet<Green_Circular> Greens { get; set; }


    }
}
