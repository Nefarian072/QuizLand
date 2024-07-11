using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizLand.DataTransferObjects.Question;

namespace QuizLand.DataTransferObjects.Quiz;

public class QuizDto
{
    public string? Name { get; set; }
    public string? Theme { get; set; }
    public string? Description { get; set; }
    public int CreatorId { get; set; }
    public IEnumerable<QuestionDto>? Questions { get; set; } = new List<QuestionDto>();

}
