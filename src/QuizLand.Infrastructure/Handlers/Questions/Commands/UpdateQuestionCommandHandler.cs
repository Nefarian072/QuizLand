using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QuizLand.Infrastructure.Responses.Questions.Command;
using QuizLand.Infrastructure.Requests.Questions.Command;
using QuizLand.DataLayer.Base.Interfaces;
using AutoMapper;
using QuizLand.DataLayer.Core.Entities;

namespace QuizLand.Infrastructure.Handlers.Questions.Commands;

public class UpdateQuestionCommandHandler: IRequestHandler<UpdateQuestionCommand, UpdateQuestionCommandResult>
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public UpdateQuestionCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public async Task<UpdateQuestionCommandResult> Handle(UpdateQuestionCommand request, CancellationToken cancellationToken)
    {
        var quiz = await _repositoryManager.QuizRepository.GetQuizWithQuestions(request.QuizId);
        if (quiz == null)
        {
            return new UpdateQuestionCommandResult
            {
                Message = "Викторина не найдена"
            };
        }
        var questions = _mapper.Map<IEnumerable<Question>>(request.Questions);
        foreach (var question in questions)
        {
            var questionFromDb = quiz.Questions.FirstOrDefault(q => q.Id == question.Id);
            if (questionFromDb == null)
            {
                await _repositoryManager.QuestionRepository.CreateAsync(question);
            }
            else
            {
                questionFromDb.Text = question.Text;
                questionFromDb.Answer = question.Answer;
            }
        }
        _repositoryManager.QuestionRepository.UpdateRangeQuestion(quiz.Questions);
        await _repositoryManager.Save();
        return new UpdateQuestionCommandResult
        {
            Message = $"Вопросы обновлены"
        };
    }
}
