using Marte.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Marte.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Int64 id);
        void Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(Int64 id);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
    }
}
