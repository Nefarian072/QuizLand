using QuizLand.DataTransferObjects.User;
namespace QuizLandInfrastructure.Responses.Users.Queries;

public class GetAllUsersQueryResult
{
    public string? Message { get; set; }
    public IEnumerable<UserDto> Users { get; set; } = new List<UserDto>();
}