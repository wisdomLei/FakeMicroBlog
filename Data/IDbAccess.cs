using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IPC.Data {
    interface IDbAccess<T> {
        List<T> GetList();
        int Add(T entity);
        void AddRange(IEnumerable<T> entitys);
        List<T> Where(Expression<Func<T, bool>> expression);
        T GetById(Expression<Func<T, object>> expression);
        void Save();
    }
}
