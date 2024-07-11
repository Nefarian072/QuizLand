using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QuizLand.Infrastructure.Responses.Quizes.Queries;

namespace QuizLand.Infrastructure.Requests.Quizes.Queries;

public class GetFirstQuestionQuery: IRequest<GetFirstQuestionQueryResult>
{
    public int QuizId { get; set; }
}
