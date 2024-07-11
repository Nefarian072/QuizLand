using QuizLand.DataTransferObjects.Question;
namespace QuizLand.WebAPI.Models.QuizModels;

public class UpdateQuizModel
{
    public int QuizId { get; set; }
    public string? Name { get; set; }
    public string? Theme { get; set; }
    public string? Description { get; set; }
}
