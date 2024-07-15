using ATS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Infrastructure.Services
{
    public class ApplicantServices<Entity> : IGenericRepository<Entity> where Entity : class
    {
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Entity Create(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int key)
        {
            throw new NotImplementedException();
        }

        public Entity Get(Expression<Func<Entity, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity> GetRange(Expression<Func<Entity, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity> GetRange(int pageNumber, byte pageSize)
        {
            throw new NotImplementedException();
        }

        public Entity Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
