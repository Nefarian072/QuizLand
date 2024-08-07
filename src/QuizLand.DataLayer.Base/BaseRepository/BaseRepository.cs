﻿using Microsoft.EntityFrameworkCore;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.WebAPI;

namespace QuizLand.DataLayer.Base.BaseRepository;

public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
{
    protected readonly QuizLandDbContext _context;
    protected readonly DbSet<T> _dbSet;
    public BaseRepository(QuizLandDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();

    }

    public virtual async Task CreateAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public virtual async Task Delete(int id)
    {
        var t = await GetById(id);
        if (t == null)
        {
            return;
        }
        _dbSet.Remove(t);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync<T>();
    }

    public async Task<T?> GetById(int id)
    {
        return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }
}
