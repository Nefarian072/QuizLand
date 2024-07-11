using QuizLand.DataLayer.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizLand.Infrastructure.Responses.Points.Commands;
using QuizLand.Infrastructure.Requests.Points.Commands;
using QuizLand.DataTransferObjects.Question;
using QuizLand.DataLayer.Core.Entities;
using AutoMapper;
using QuizLand.Infrastructure.Responses.Quizes.Commands;
using MediatR;

namespace QuizLand.Infrastructure.Handlers.Points.Commands;

public class RateTheAnswerCommandHandler: IRequestHandler<RateTheAnswerCommand, RateTheAnswerCommandResult>
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public RateTheAnswerCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public async Task<RateTheAnswerCommandResult> Handle(RateTheAnswerCommand request, CancellationToken cancellationToken)
    {
        var quiz = await _repositoryManager.QuizRepository.GetQuizWithQuestions(request.QuizId);
        if (quiz == null)
        {
            return new RateTheAnswerCommandResult
            {
                Message = "Викторина не найдена"
            };
        }
        var questions = _mapper.Map<IEnumerable<QuestionDto>>(quiz.Questions);
        var answers = request.Answers;
        var score = 0;
        for (int i = 0; i < questions.Count(); i++)
        {
            if (answers.ElementAt(i)== questions.ElementAt(i).Answer)
            {
                score++;
            }
        }
        var point = new Point
        {
            QuizId = quiz.Id,
            UserId = request.ParticipantId,
            Count = score
        };
        await _repositoryManager.PointRepository.CreateAsync(point);
        await _repositoryManager.Save();
        return new RateTheAnswerCommandResult
        {
            Score = score,
            QuizId = quiz.Id,
            ParticipantId = request.ParticipantId,
            Message = $"Ваш результат {score} из {questions.Count()}"
        };

    }
}
