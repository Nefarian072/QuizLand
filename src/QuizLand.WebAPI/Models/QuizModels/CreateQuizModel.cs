using QuizLand.DataLayer.Core.Entities;
using System.Collections.Generic;
using QuizLand.DataTransferObjects.Question;

namespace QuizLand.WebAPI.Models.QuizModels;

public class CreateQuizModel
{
    public string? Name { get; set; }
    public string? Theme { get; set; }
    public string? Description { get; set; }
    public int CreatorId { get; set; }

    public IEnumerable<QuestionDto>? Questions { get; set; } = new List<QuestionDto>();
}
