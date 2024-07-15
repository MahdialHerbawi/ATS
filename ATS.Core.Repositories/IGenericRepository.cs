using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Core.Repositories
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Entity Get(int key);
        Entity Get(Expression<Func<Entity, bool>> expression = null);
        IEnumerable<Entity> GetRange(Expression<Func<Entity, bool>> expression = null);
        IEnumerable<Entity> GetRange(int pageNumber, byte pageSize);
        Entity Create(Entity entity);
        void Delete(Entity entity);
        Entity Update(Entity entity);
        void Commit();
    }
}
