using MediatR;
using QuizLand.DataLayer.Core.Entities;
using QuizLandInfrastructure.Responses.Users.Queries;
namespace QuizLandInfrastructure.Requests.Users.Queries;

public class GetAllUsersQuery : IRequest<GetAllUsersQueryResult>
{
    public IEnumerable<User> Users { get; set; }
}
