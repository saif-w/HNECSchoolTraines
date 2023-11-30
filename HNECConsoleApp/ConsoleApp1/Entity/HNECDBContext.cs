using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    public class HNECDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HNECStudintDB;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False")
                ;
        }
        public DbSet<Studints> Studints { get; set; }
        public DbSet<Enrollament> Enrollaments { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Instructers> Instructers { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Offices> Offices { get; set; }

    }
}
