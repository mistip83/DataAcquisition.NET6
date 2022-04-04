using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAcquisition.Core.Interfaces.Repositories;

/// <summary>
/// Single point for data access
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T>
{
    /// <summary>
    /// Add a row to db
    /// </summary>
    /// <param name="entity"></param>
    Task AddAsync(T entity);

    /// <summary>
    /// Add a row list to db
    /// </summary>
    /// <param name="entities"></param>
    Task AddRangeAsync(IEnumerable<T> entities);

    /// <summary>
    /// Get all rows for corresponding entity
    /// </summary>
    Task<IEnumerable<T>> GetAllAsync();

    /// <summary>
    /// Get entity by id
    /// </summary>
    /// <param name="id"></param>
    Task<T> GetByIdAsync(int id);

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
    /// Get by any parameter
    /// </summary>
    /// <param name="predicate"></param>
    Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);

    /// <summary>
    /// Update a db row
    /// </summary>
    /// <param name="entity"></param>
    T Update(T entity);

    /// <summary>
    /// Search something
    /// </summary>
    /// <param name="predicate"></param>
    Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> predicate);
}