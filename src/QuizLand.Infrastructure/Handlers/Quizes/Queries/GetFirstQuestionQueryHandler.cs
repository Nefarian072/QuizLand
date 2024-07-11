using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QuizLand.Infrastructure.Responses.Quizes.Queries;
using QuizLand.Infrastructure.Requests.Quizes.Queries;
using AutoMapper;
using QuizLand.DataLayer.Base.Interfaces;

namespace QuizLand.Infrastructure.Handlers.Quizes.Queries;

public class GetFirstQuestionQueryHandler: IRequestHandler<GetFirstQuestionQuery, GetFirstQuestionQueryResult>
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    public GetFirstQuestionQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }
    public async Task<GetFirstQuestionQueryResult> Handle(GetFirstQuestionQuery request, CancellationToken cancellationToken)
    {
        var quiz = await _repositoryManager.QuizRepository.GetQuizWithQuestions(request.QuizId);
        if (quiz == null)
        {
            return new GetFirstQuestionQueryResult
            {
                Text = "Викторина не найдена"
            };
        }
        var question = quiz.Questions?.FirstOrDefault();
        if (question == null)
        {
            return new GetFirstQuestionQueryResult
            {
                Text = "Вопросы не найдены"
            };
        }
        return new GetFirstQuestionQueryResult
        {
            Text = question.Text
        };
    }
}
