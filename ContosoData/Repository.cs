using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly IDbSet<T> dbset;
        protected ContosoDbContext _context;

        public Repository(ContosoDbContext context)
        {
            _context = context;
            dbset = context.Set<T>();
        }
        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.AsNoTracking().ToList();
            // asnotracking  improving the performance,do not track just return raw data. by default EF will track
        }

        public T GetById(int id)
        {
            return dbset.Find(id);
        }

        public IQueryable<T> GetQuerayable()
        {
            return dbset.AsQueryable();
        }

        public void Update(T entity)
        {
            dbset.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
