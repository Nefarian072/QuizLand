using QuizLand.DataLayer.Core.Entities;

namespace QuizLand.DataLayer.Base.Interfaces;

public interface IPointRepository : IRepository<Point>
{
    public Task<bool> CheckPointsByUserIdAndQuizId(int userId, int quizId);
}
