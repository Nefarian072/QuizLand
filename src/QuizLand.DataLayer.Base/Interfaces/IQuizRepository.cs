using QuizLand.DataLayer.Core.Entities;

namespace QuizLand.DataLayer.Base.Interfaces;

public interface IQuizRepository : IRepository<Quiz>
{
    public Task<Quiz?> GetQuizWithQuestions(int id);
}
