using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class Enrollament
    {
        public int EnrollamentId { get; set; }
        public string? Grade { get; set; }
        public virtual Studints? Studints { get; set; }
        public virtual Courses Courses { get; set; }
    }
}
