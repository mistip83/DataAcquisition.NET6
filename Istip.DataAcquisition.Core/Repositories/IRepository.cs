using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Istip.DataAcquisition.Core.Repositories
{
    /// <summary>
    /// Single point for data access
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T:class
    {
        /// <summary>
        /// Provide user list for login screen
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllUsersByOrganizationIdAsync(int id);

        /// <summary>
        /// Search something
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

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
        Task AddAsync(T entity);

        /// <summary>
        /// Add a row list to db
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task AddRangeAsync(IEnumerable<T> entities);

        /// <summary>
        /// Remove row from db
        /// </summary>
        /// <param name="entity"></param>
        void Remove(T entity);

        /// <summary>
        /// Remove row list from db
        /// </summary>
        /// <param name="entity"></param>
        void RemoveRange(T entity);

        /// <summary>
        /// Update a db row
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Update(T entity);
    }
}
