using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public class DepartmentRepository:Repository<Department>,IDepartmentRepository
    {
        public DepartmentRepository(ContosoDbContext context):base(context)
        {

        }
        public List<Department> GetDeptWithCourses()
        {
            var Depts = _context.Departments.Include("Course").ToList();
            return Depts;
        }

    }
    public interface IDepartmentRepository:IRepository<Department>
    {
        List<Department> GetDeptWithCourses();
    }
}
