using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAcquisition.Interface.Services
{
    /// <summary>
    /// Communicate with repositories
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IService<T> where T:class
    {
        /// <summary>
        /// Get all rows
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Get data by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(Guid id);

        /// <summary>
        /// Search something
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Get by any parameter
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Add a row to db
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> AddAsync(T entity);

        /// <summary>
        /// Add a row list to db
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<List<T>> AddRangeAsync(List<T> entities);

        /// <summary>
        /// Remove row from db
        /// </summary>
        /// <param name="entity"></param>
        void Remove(T entity);

        /// <summary>
        /// Remove row list from db
        /// </summary>
        /// <param name="entities"></param>
        void RemoveRange(IEnumerable<T> entities);

        /// <summary>
        /// Update a db row
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Update(T entity);
    }
}
