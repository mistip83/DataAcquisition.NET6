﻿using System.Linq.Expressions;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.DataAccessEF.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Repository.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext Context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        Context = context;
        _dbSet = context.Set<T>();
    }

    /// <summary>
    /// Add a row to db
    /// </summary>
    /// <param name="entity"></param>
    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    /// <summary>
    /// Add a row list to db
    /// </summary>
    /// <param name="entities"></param>
    public async Task AddRangeAsync(IEnumerable<T> entities)
    {
        await _dbSet.AddRangeAsync(entities);
    }

    /// <summary>
    /// Get all rows for corresponding entity
    /// </summary>
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    /// <summary>
    /// Get entity by id
    /// </summary>
    /// <param name="id"></param>
    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    /// <summary>
    /// Remove row from db
    /// </summary>
    /// <param name="entity"></param>
    public void Remove(T entity)
    {
        _dbSet.Remove((entity));
    }

    /// <summary>
    /// Remove row list from db
    /// </summary>
    /// <param name="entities"></param>
    public void RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange((entities));
    }

    /// <summary>
    /// Get by any parameter
    /// </summary>
    /// <param name="predicate"></param>
    public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.SingleOrDefaultAsync(predicate);
    }

    /// <summary>
    /// Update a db row
    /// </summary>
    /// <param name="entity"></param>
    public T Update(T entity)
    {
        Context.Entry(entity).State = EntityState.Modified;

        return entity;
    }

    /// <summary>
    /// Search something
    /// </summary>
    /// <param name="predicate"></param>
    public async Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }
}