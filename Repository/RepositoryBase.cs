using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using EFCore.BulkExtensions;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
  public abstract  class RepositoryBase<T>:IRepositoryBase<T> where T:class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        protected RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
           // return this.RepositoryContext.Set<T>().AsNoTracking();
            return this.RepositoryContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }


        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        void IRepositoryBase<T>.Insert(T t)
        {
            this.RepositoryContext.Set<T>().Add(t);
        }

        public void Insert(IList<T> t)
        {
            RepositoryContext.BulkInsert(t);
        }

        public void Delete<Value>(int id)
        {
            var model = RepositoryContext.Set<T>().Find(id);
            RepositoryContext.Set<T>().Remove(model);
        }

        public void Delete(Expression<Func<T, bool>> whereLambda)
        {
            throw new NotImplementedException();
        }

        public void Update(IList<T> entities)
        {
            throw new NotImplementedException();
        }

        public T FindByID(int Id)
        {
            throw new NotImplementedException();
        }

        public T GetFirstDefault(Expression<Func<T, bool>> whereLambda = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(string whereLambda = null)
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<T, bool>> whereLambda = null)
        {
            throw new NotImplementedException();
        }

        public void ExecuteSQL(string sql, object dyParmaters = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Value> Reader<Value>(string sql, object dyParmaters = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Value> ReaderSingle<Value>(string sql, object dyParmaters = null)
        {
            throw new NotImplementedException();
        }

        public Value ExecuteScalar<Value>(string sql, object dyParmaters = null)
        {
            throw new NotImplementedException();
        }
    }
}
