using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QuizLand.Infrastructure.Responses.Quizes.Queries;
using QuizLand.Infrastructure.Requests.Quizes.Queries;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.DataTransferObjects.Question;
using AutoMapper;

namespace QuizLand.Infrastructure.Handlers.Quizes.Queries;

public class GetQuestionsQueryHandler: IRequestHandler<GetQuestionsQuery, GetQuestionsQueryResult>
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public GetQuestionsQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public async Task<GetQuestionsQueryResult> Handle(GetQuestionsQuery request, CancellationToken cancellationToken)
    {
        var quiz = await _repositoryManager.QuizRepository.GetQuizWithQuestions(request.QuizId);
        var questions = _mapper.Map<IEnumerable<QuestionDto>>(quiz.Questions);
        return new GetQuestionsQueryResult
        {
            Questions = questions
        };
    }
}
