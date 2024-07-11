using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLand.Infrastructure.Responses.Points.Commands;

public class RateTheAnswerCommandResult
{
    public int ParticipantId { get; set; }
    public int QuizId { get; set; }
    public int Score { get; set; }
    public string Message { get; set; }
}
