using MediatR;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLandInfrastructure.Requests.Users.Queries;
using QuizLandInfrastructure.Responses.Users.Queries;
namespace QuizLandInfrastructure.Handlers.Users.Queries;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, GetAllUsersQueryResult>
{
    private readonly IRepositoryManager _repositoryManager;
    public GetAllUsersQueryHandler(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }
    public async Task<GetAllUsersQueryResult> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _repositoryManager.UserRepository.GetAllAsync(); //переделал под асинхронный
        if (!users.Any())
        {
            return new GetAllUsersQueryResult
            {
                message = "Пользователи не найдены"
            };
        }
        else
        {
            return new GetAllUsersQueryResult
            {
                message = "Пользователи найдены"
            };
        }
    }
}
