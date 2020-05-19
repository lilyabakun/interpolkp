using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interpolkp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // using(var con=new Connection())
            //{
            //    var dep = new Department("l","l",5,5,2);
                
            //    con.Departments.Add(dep);
            //    con.SaveChanges();

            //}
            /*using(var context = new MyDBConnect())
           {
               var group = new Group()
               {
                   Name = "Ramstaim",
                   Year = 1994
               };
               context.Groups.Add(group);
               context.SaveChanges();
               Console.WriteLine($"id: {group.ID} name {group.Name} year:{group.Year}");
           }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
