using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using IPS.Models;
using IPS.Service;

namespace IPS.Provider {
    public class DbProvider<T> : IDbService<T> {
        public ReturnModel Add(T entity) {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<T> entitys) {
            throw new NotImplementedException();
        }

        public T FirstOfDefault(Expression<Func<T, bool>> expression) {
            throw new NotImplementedException();
        }

        public List<T> GetAll() {
            throw new NotImplementedException();
        }

        public object GetBy(Func<object, bool> p) {
            throw new NotImplementedException();
        }

        public T GetById(Expression<Func<T, object>> expression) {
            throw new NotImplementedException();
        }

        public List<T> Where(Expression<Func<T, bool>> expression) {
            throw new NotImplementedException();
        }
    }
}
