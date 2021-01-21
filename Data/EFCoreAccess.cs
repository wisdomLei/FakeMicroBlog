using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IPC.Data {
    class EFCoreAccess<T> : IDbAccess<T> {
        public int Add(T entity) {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<T> entitys) {
            throw new NotImplementedException();
        }

        public T GetById(Expression<Func<T, object>> expression) {
            throw new NotImplementedException();
        }

        public List<T> GetList() {
            throw new NotImplementedException();
        }

        public void Save() {
            throw new NotImplementedException();
        }

        public List<T> Where(Expression<Func<T, bool>> expression) {
            throw new NotImplementedException();
        }
    }
}
