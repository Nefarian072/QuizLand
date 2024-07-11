using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QuizLand.Infrastructure.Responses.Questions.Command;
using QuizLand.DataTransferObjects.Question;

namespace QuizLand.Infrastructure.Requests.Questions.Command;

public class UpdateQuestionCommand: IRequest<UpdateQuestionCommandResult>
{
    public int QuizId { get; set; }
    public IEnumerable<QuestionDto>? Questions { get; set; } = new List<QuestionDto>();
}
