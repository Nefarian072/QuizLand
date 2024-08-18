using Microsoft.EntityFrameworkCore;
using QuizLand.DataLayer.Base.BaseRepository;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.WebAPI;

namespace QuizLand.DataLayer.Base.Repositories;

public class PointRepository : BaseRepository<Point>, IPointRepository
{
    public PointRepository(QuizLandDbContext context) : base(context)
    {
    }

    public async Task<bool> CheckPointsByUserIdAndQuizId(int userId, int quizId)
    {
        return await _context.Points.AnyAsync(p => p.UserId == userId && p.QuizId == quizId);
    }
}
