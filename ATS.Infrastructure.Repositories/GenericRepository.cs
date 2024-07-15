using ATS.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Infrastructure.Repositories
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        DbContext _context;
        DbSet<Entity> _dbSet;
        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Entity>();
        }
        public IEnumerable<Entity> GetRange(Expression<Func<Entity, bool>> expression = null)
        {
            IEnumerable<Entity> dbset = _dbSet;
            if (expression != null)
                dbset = _dbSet.Where(expression);
            return dbset;
        }

        public Entity Update(Entity entity)
        {
            return _dbSet.Update(entity).Entity;
        }

        public Entity Create(Entity entity)
        {
            return _dbSet.Add(entity).Entity;
        }

        public void Delete(Entity entity)
        {
            _dbSet.Remove(entity);
        }

        public Entity Get(int key)
        {
            return _dbSet.Find(key);
        }

        public Entity Get(Expression<Func<Entity, bool>> expression)
        {
            if (expression == null)
                throw new Exception("Record Not Found");
            return _dbSet.Where(expression).FirstOrDefault()!;
        }

        public IEnumerable<Entity> GetRange(int pageNumber, byte pageSize)
        {
            var query = _dbSet.AsQueryable();
            var data = query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return data;
        }

        public virtual void Commit()
        {
            _context.SaveChanges();
        }
    }
}
