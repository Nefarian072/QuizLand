using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QuizLand.DataTransferObjects.Question;
using QuizLand.Infrastructure.Responses.Quizes.Commands;

namespace QuizLand.Infrastructure.Requests.Quizes.Commands;

public class CreateQuizCommand: IRequest<CreateQuizCommandResult>
{
    public string? Name { get; set; }
    public string? Theme { get; set; }
    public string? Description { get; set; }
    public int CreatorId { get; set; }
    public IEnumerable<QuestionDto>? Questions { get; set; } = new List<QuestionDto>();
}
