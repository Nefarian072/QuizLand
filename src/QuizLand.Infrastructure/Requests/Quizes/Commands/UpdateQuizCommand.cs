using MediatR;
using QuizLand.DataTransferObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizLand.Infrastructure.Responses.Quizes.Commands;

namespace QuizLand.Infrastructure.Requests.Quizes.Commands;

public class UpdateQuizCommand: IRequest<UpdateQuizCommandResult>
{
    public int QuizId { get; set; }
    public string? Name { get; set; }
    public string? Theme { get; set; }
    public string? Description { get; set; }
}
