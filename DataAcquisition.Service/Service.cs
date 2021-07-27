using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;
using DataAcquisition.Interface.UnitOfWorks;

namespace DataAcquisition.Service
{
    /// <summary>
    /// Base class for other service classes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Service<T> : IService<T> where T : class
    {
        protected readonly IUnitOfWork UnitOfWork;
        private readonly IRepository<T> _repository;

        /// <summary>
        /// UnitOfWork is used by classes derived from this class
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="repository"></param>
        public Service(IUnitOfWork unitOfWork, IRepository<T> repository)
        {
            UnitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await UnitOfWork.CommitAsync();

            return entity;
        }

        public async Task<List<T>> AddRangeAsync(List<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            await UnitOfWork.CommitAsync();

            return entities;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public void Remove(T entity)
        {
            _repository.Remove(entity);
            UnitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
            UnitOfWork.Commit();
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _repository.SingleOrDefaultAsync(predicate);
        }

        public T Update(T entity)
        {
            var updatedEntity = _repository.Update(entity);
            UnitOfWork.Commit();

            return updatedEntity;
        }

        public async Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await _repository.WhereAsync(predicate);
        }
    }
}
