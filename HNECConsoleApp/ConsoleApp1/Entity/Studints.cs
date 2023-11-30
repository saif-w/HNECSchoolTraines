using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class Studints
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="u have to put only 50 chartecrs")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollament> Enrollament { get; set; }=new HashSet<Enrollament>();
    }
}
