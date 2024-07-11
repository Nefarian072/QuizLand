namespace QuizLand.WebAPI.Models.PointModels;

public class RateTheAnswerModel
{
    public int QuizId { get; set; }
    public IEnumerable<bool> Answers { get ; set; } = new List<bool>();
}
