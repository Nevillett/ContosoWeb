using ContosoData;
using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this._personRepository = personRepository;        
        }
        public IEnumerable<People> GetAllPeople()
        {
            return _personRepository.GetAll();
        }
        public People GetPersonById(int id)
        {
            return _personRepository.GetById(id);
        }
        public void AddPerson(People person)
        {
            _personRepository.Add(person);
            _personRepository.SaveChanges();
        }
        public void DeletePerson(People person)
        {
            _personRepository.Delete(person);
            _personRepository.SaveChanges();
        }
    }
    public interface IPersonService
    {
        IEnumerable<People> GetAllPeople();
        People GetPersonById(int id);
        void AddPerson(People person);
        void DeletePerson(People person);
    }
}
