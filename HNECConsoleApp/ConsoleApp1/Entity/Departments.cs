using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budjet { get; set; }
        public DateTime StartDate { get; set; }
        public int InstructersId { get; set; }
        public virtual Instructers Adminstaritor { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }

      }
}
