using ContosoData;
using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public class CourseService : ICourseService
    {
        private readonly ICourseReository _courseRepository;
        public CourseService(ICourseReository courseRepository)
        {
            this._courseRepository = courseRepository;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();
        }
    }
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();
    }
}
