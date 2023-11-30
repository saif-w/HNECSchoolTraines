using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class Courses
    {
        public int CoursesId { get; set; }
        public string? Titel { get; set; }
        public int Credit { get; set; }
        public Departments Departments { get; set; }
        public int DepartmentId { get; set; }
        public virtual ICollection<Instructers> Instructers { get; set; }
        public virtual ICollection<Enrollament> Enrollament { get; set; } = new HashSet<Enrollament>();
    }
}
