using Microsoft.EntityFrameworkCore;
using QuizLand.DataLayer.Base.BaseRepository;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.WebAPI;

namespace QuizLand.DataLayer.Base.Repositories;

public class QuizRepository : BaseRepository<Quiz>, IQuizRepository
{
    public QuizRepository(QuizLandDbContext context) : base(context)
    {
    }

    public async Task <Quiz?> GetQuizWithQuestions(int id)
    {
        return await _dbSet.AsNoTracking().Include(x => x.Questions).FirstOrDefaultAsync(x => x.Id == id);
    }
}
