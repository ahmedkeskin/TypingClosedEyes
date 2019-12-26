using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TypingClosedEyes.DataAccess.Interface
{
    public interface IEntityRepository<T>
    {
        IEnumerable<T> GetList(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);

    }
}
