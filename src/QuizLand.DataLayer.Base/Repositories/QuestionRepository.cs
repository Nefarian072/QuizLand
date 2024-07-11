using QuizLand.DataLayer.Base.BaseRepository;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.WebAPI;

namespace QuizLand.DataLayer.Base.Repositories;

public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
{
    public QuestionRepository(QuizLandDbContext context) : base(context)
    {
    }

    public void UpdateRangeQuestion(IEnumerable<Question> questions)
    {
        _dbSet.UpdateRange(questions);
    }
}

