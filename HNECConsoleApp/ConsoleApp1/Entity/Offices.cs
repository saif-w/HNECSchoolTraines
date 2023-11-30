using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class Offices
    {
        [Key]
        public int InstructersId { get; set; }
        public string Location { get; set; }
        public virtual Instructers Instructer { get; set; }

    }
}
