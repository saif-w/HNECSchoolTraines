using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class Instructers
    {
        public int Id { get; set; }
        public string FirstMiddelName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public  string Fullname
        {
            get { return FirstMiddelName + " " + LastName; }
        }
        //public virtual ICollection<Courses> Courses { get; set; }
        public virtual Offices? Office { get; set; }
    }
}
