using MediatR;
using QuizLand.DataLayer.Core.Entities;
namespace QuizLand.DataLayer.Core.Notes.Commands.CreateNote;

public class CreareUserCommand : IRequest<User>
{
    public int UserId { get; set; }
}
