using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public class PersonRepository:Repository<People>,IPersonRepository
    {
        public PersonRepository(ContosoDbContext context):base(context)
        {

        }
        public People GetByLastName(string lastname)
        {
            var people = _context.People.Where(p => p.LastName == lastname).FirstOrDefault();
                return people;
        }

    }
    public interface IPersonRepository:IRepository<People>
        //add specific method inside this one
    {
        People GetByLastName(string name);
    }
}
