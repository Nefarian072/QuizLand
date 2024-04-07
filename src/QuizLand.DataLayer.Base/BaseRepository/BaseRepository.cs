using Microsoft.EntityFrameworkCore;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLand.DataLayer.Base.BaseRepository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly QuizLandDbContext _context;
        private readonly DbSet<T> _dbSet;
        public BaseRepository(QuizLandDbContext context)
        {
            _context=context;
            _dbSet = _context.Set<T>();

        }
        
        public async void Create(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async void Delete(int id)
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

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
