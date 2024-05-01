using MediatR;
using QuizLandInfrastructure.Responses.Users.Commands;
namespace QuizLandInfrastructure.Requests.Users.Commands;

public class CreateUserCommand : IRequest<CreateUserCommandResult>
{

    public string Name { get; set; }

    public string Email { get; set; }

    public byte[] Password { get; set; }
}
