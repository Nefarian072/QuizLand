using MediatR;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Core.Entities;
using QuizLandInfrastructure.Requests.Users.Commands;
using QuizLandInfrastructure.Responses.Users.Commands;
namespace QuizLand.Infrastructure.Handlers.Users.Commands;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResult>
{
    private readonly IRepositoryManager _repositoryManager;
    public CreateUserCommandHandler(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }

    public async Task<CreateUserCommandResult> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            Name = request.Name, // скорее всего буду использовать requestForm.Name. Но это когда фронт будет готов.
            Email = request.Email,
            Password = request.Password,
        };

        if (_repositoryManager.UserRepository.GetByEmail(user.Email) != null)
        {
            return new CreateUserCommandResult
            {
                ErrorMessage = "Пользователь не создан"
            };
        }
        await _repositoryManager.UserRepository.CreateAsync(user);
        await _repositoryManager.Save();
        return new CreateUserCommandResult
        {
            UserName = user.Name
        };
    }
}
