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
        await _context.SaveChangesAsync();
    }

    public virtual async Task Delete(int id)
    {
        var t = GetById(id);
        if (t == null)
        {
            return;
        }
        _dbSet.Remove(t);
        await _context.SaveChangesAsync();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList<T>();
    }

    public T? GetById(int id)
    {
        return _dbSet.FirstOrDefault(x => x.Id == id);
    }

    public async Task Update(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }
}
