using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QuizLand.Infrastructure.Responses.Quizes.Commands;

namespace QuizLand.Infrastructure.Requests.Quizes.Commands;

public class DeleteQuizCommand: IRequest<DeleteQuizCommandResult>
{
    public int QuizId { get; set; }
}
