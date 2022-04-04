using System.Linq.Expressions;

namespace DataAcquisition.Core.Interfaces.Services;

/// <summary>
/// Communicate with repositories
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IService<T> where T:class
{
    /// <summary>
    /// Get all rows
    /// </summary>
    Task<IEnumerable<T>> GetAllAsync();

    /// <summary>
    /// Get data by id
    /// </summary>
    /// <param name="id"></param>
    Task<T> GetByIdAsync(int id);

    /// <summary>
    /// Search something
    /// </summary>
    /// <param name="predicate"></param>
    Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> predicate);

    /// <summary>
    /// Get by any parameter
    /// </summary>
    /// <param name="predicate"></param>
    Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);

    /// <summary>
    /// Add a row to db
    /// </summary>
    /// <param name="entity"></param>
    Task<T> AddAsync(T entity);

    /// <summary>
    /// Add a row list to db
    /// </summary>
    /// <param name="entities"></param>
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
    T Update(T entity);
}