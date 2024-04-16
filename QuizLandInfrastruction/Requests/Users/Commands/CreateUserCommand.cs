using MediatR;
using QuizLandInfrastructure.Responses.Users.Commands;
using System.ComponentModel.DataAnnotations;
namespace QuizLandInfrastructure.Requests.Users.Commands;

public class CreateUserCommand : IRequest<CreateUserCommandResult>
{
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public byte[] Password { get; set; }
}
