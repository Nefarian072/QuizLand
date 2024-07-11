using MediatR;
using QuizLand.Infrastructure.Responses.Points.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLand.Infrastructure.Requests.Points.Commands;

public class RateTheAnswerCommand: IRequest<RateTheAnswerCommandResult>
{
    public int QuizId { get; set; }
    public int ParticipantId { get; set; }
    public IEnumerable<bool> Answers { get; set; } = new List<bool>();
}
