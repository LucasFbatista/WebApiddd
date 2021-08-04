using RestApiDDD.Domain.Core.Interfaces.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly SqlContext _sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Add(T objeto)
        {
            try
            {
                _sqlContext.Set<T>().Add(objeto);
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _sqlContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _sqlContext.Set<T>().Find(id);
        }

        public void Remove(T objeto)
        {
            try
            {
                _sqlContext.Set<T>().Remove(objeto);
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T objeto)
        {
            try
            {
                _sqlContext.Set<T>().Update(objeto);
                _sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}