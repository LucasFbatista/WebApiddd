using System.Collections.Generic;

namespace RestApiDDD.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T objeto);

        void Update(T objeto);

        void Remove(T objeto);

        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}