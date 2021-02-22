using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using IPS.Models;

namespace IPS.Service {
    public interface IDbService<T> {
        List<T> GetAll();
        ReturnModel Add(T entity);
        void AddRange(IEnumerable<T> entitys);
        List<T> Where(Expression<Func<T, bool>> expression);
        T GetById(Expression<Func<T, object>> expression);
        T FirstOfDefault(Expression<Func<T, bool>> expression);
        object GetBy(Func<object, bool> p);
    }
}
