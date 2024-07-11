using MediatR;
using QuizLand.Infrastructure.Responses.Quizes.Queries;
namespace QuizLand.Infrastructure.Requests.Quizes.Queries;

public class GetQuizQuery: IRequest<GetQuizQueryResult>
{
    public int QuizId { get; set; }
}
