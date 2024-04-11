using QuizLand.DataLayer.Core.Entities;

namespace QuizLand.DataLayer.Base.Interfaces;

public interface IRepository<T> where T:IEntity
{
    public Task CreateAsync(T entity);
    public T? GetById(int id);
    public IEnumerable<T> GetAll();
    public Task Update(T entity);
    public Task Delete(int id);
}
