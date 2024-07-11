using QuizLand.DataTransferObjects.Question;
namespace QuizLand.WebAPI.Models.QuestionModels;

public class UpdateQuestionModel
{
    public int QuizId { get; set; }

    public IEnumerable<QuestionDto>? Questions { get; set; } = new List<QuestionDto>();
}
