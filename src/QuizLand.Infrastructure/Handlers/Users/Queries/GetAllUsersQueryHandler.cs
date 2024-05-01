using AutoMapper;
using MediatR;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataTransferObjects.User;
using QuizLandInfrastructure.Requests.Users.Queries;
using QuizLandInfrastructure.Responses.Users.Queries;
namespace QuizLandInfrastructure.Handlers.Users.Queries;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, GetAllUsersQueryResult>
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    public GetAllUsersQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }
    public async Task<GetAllUsersQueryResult> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _repositoryManager.UserRepository.GetAllAsync(); //переделал под асинхронный
        if (!users.Any())
        {
            return new GetAllUsersQueryResult
            {
                Message = "Пользователи не найдены"
            };
        }
        return new GetAllUsersQueryResult
        {
            Message = "Пользователи найдены",
            Users = _mapper.Map<IEnumerable<UserDto>>(users.ToList())
        };
    }
}