using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizLand.Infrastructure.Responses.Quizes.Queries;
using QuizLand.Infrastructure.Requests.Quizes.Queries;
using QuizLand.DataLayer.Base.Interfaces;
using AutoMapper;

namespace QuizLand.Infrastructure.Handlers.Quizes.Queries;

public class GetQuizQueryHandler : IRequestHandler<GetQuizQuery, GetQuizQueryResult>
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    public GetQuizQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public async Task<GetQuizQueryResult> Handle(GetQuizQuery request, CancellationToken cancellationToken)
    {
        var quiz = await _repositoryManager.QuizRepository.GetById(request.QuizId);
        if (quiz == null)
        {
            return new GetQuizQueryResult 
            { 
                Message = "Такая викторина не найдена" 
            };
        }
        return new GetQuizQueryResult
        {
            Name = quiz.Name,
            Description = quiz.Description,
            Theme = quiz.Theme,
        };
    }
}
