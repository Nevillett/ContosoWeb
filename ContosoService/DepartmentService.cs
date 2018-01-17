using ContosoData;
using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            this._departmentRepository = departmentRepository;
        }
        public IEnumerable<Department> GetAllDept()
        {
            return _departmentRepository.GetAll();
        }
        public List<Department> GetDeptWithCourses()
        {
            return _departmentRepository.GetDeptWithCourses();
        }
    }
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDept();
        List<Department> GetDeptWithCourses();

    }
}
