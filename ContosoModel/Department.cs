using ContosoModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModel
{
    public class Department:AuditableEntity
    {
        public String Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime? StartDate { get; set; }
        public ICollection<Course> Course { get; set; }
    }
}
