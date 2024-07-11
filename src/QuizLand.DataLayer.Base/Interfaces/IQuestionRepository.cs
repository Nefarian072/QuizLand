using QuizLand.DataLayer.Core.Entities;

namespace QuizLand.DataLayer.Base.Interfaces;

public interface IQuestionRepository : IRepository<Question>
{
    public void UpdateRangeQuestion(IEnumerable<Question> questions);
}
