using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public class CourseRepository : Repository<Course>, ICourseReository
    {
        public CourseRepository(ContosoDbContext context) : base(context)
        {

        }
    }
    public interface ICourseReository : IRepository<Course>
    {

    }
}
