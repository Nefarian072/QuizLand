using MediatR;
using QuizLand.DataTransferObjects.User;
using QuizLandInfrastructure.Responses.Users.Queries;
namespace QuizLandInfrastructure.Requests.Users.Queries;

public class GetAllUsersQuery : IRequest<GetAllUsersQueryResult>
{
    public IEnumerable<UserDto> Users { get; set; } = new List<UserDto>();
}
