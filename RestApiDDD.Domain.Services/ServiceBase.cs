using RestApiDDD.Domain.Core.Interfaces.Repositorys;
using RestApiDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiDDD.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public void Add(T objeto)
        {
            _repository.Add(objeto);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(T objeto)
        {
            _repository.Remove(objeto);
        }

        public void Update(T objeto)
        {
            _repository.Update(objeto);
        }
    }
}