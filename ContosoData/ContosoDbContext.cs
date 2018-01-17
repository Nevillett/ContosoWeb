using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ContosoModel;

namespace ContosoData
{
    public class ContosoDbContext : DbContext
    {
        public ContosoDbContext() : base("name = ContosoDbContext")
        {
            
        }
        public DbSet<People> People { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
