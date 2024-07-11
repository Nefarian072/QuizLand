using MediatR;
using QuizLand.Infrastructure.Requests.Quizes.Commands;
using QuizLand.Infrastructure.Responses.Quizes.Commands;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataLayer.Core.Entities;
using AutoMapper;
namespace QuizLand.Infrastructure.Handlers.Quizes.Commands;

public class CreateQuizCommandHandler : IRequestHandler<CreateQuizCommand, CreateQuizCommandResult>
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    public CreateQuizCommandHandler(IRepositoryManager repositoryManager,IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public async Task<CreateQuizCommandResult> Handle(CreateQuizCommand request, CancellationToken cancellationToken)
    {
        var quiz = new Quiz
        {
            Name = request.Name,
            CreatorId = request.CreatorId,
            Description = request.Description,
            Theme = request.Theme,
            Questions = _mapper.Map<IEnumerable<Question>>(request.Questions)
        };

        await _repositoryManager.QuizRepository.CreateAsync(quiz);
        await _repositoryManager.Save();
        return new CreateQuizCommandResult
        {
            Name = quiz.Name,
            CreatorId = quiz.CreatorId,
            Description = quiz.Description,
            Theme = quiz.Theme,
        };
    }
}
