using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class operation
    {
        public static void AddStudints(Studints studints)
        {
            
            HNECDBContext context = new HNECDBContext();
            context.Studints.Add(studints);
            context.SaveChanges();

        }
        public static void RemoveStudints(int id)
        {

            HNECDBContext context = new HNECDBContext();
            var studints = context.Studints.Find(id);
            context.Studints.Remove(studints);
            context.SaveChanges();

        }

        public static void UpdateStudints(int id, Studints studint)
        {

            HNECDBContext context = new HNECDBContext();
            var std = context.Studints.Find(id);

            std.FirstName=studint.FirstName;
            std.LastName=studint.LastName;
            std.Enrollament=studint.Enrollament;

            context.Studints.Update(std);
            context.SaveChanges();

        }
    }
}
