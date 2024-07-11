using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QuizLand.Infrastructure.Responses.Quizes.Commands;
using QuizLand.Infrastructure.Requests.Quizes.Commands;
using QuizLand.DataLayer.Base.Interfaces;
using AutoMapper;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.Infrastructure.Requests.Questions.Command;
namespace QuizLand.Infrastructure.Handlers.Quizes.Commands;

public class UpdateQuizCommandHandler : IRequestHandler<UpdateQuizCommand, UpdateQuizCommandResult>
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;
    public UpdateQuizCommandHandler(IRepositoryManager repositoryManager, IMapper mapper, IMediator mediator)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
        _mediator = mediator;
    }
    public async Task<UpdateQuizCommandResult> Handle(UpdateQuizCommand request, CancellationToken cancellationToken)
    {
        var quiz = await _repositoryManager.QuizRepository.GetQuizWithQuestions(request.QuizId);
        if (quiz == null)
        {
            return new UpdateQuizCommandResult
            {
                Message = "Викторина не найдена"
            };
        }
/*        await _mediator.Send(new UpdateQuestionCommand
        {
            QuizId = quiz.Id,
            Questions = request.Questions
        });*/
        quiz.Name = request.Name;
        quiz.Description = request.Description;
        quiz.Theme = request.Theme;
        _repositoryManager.QuizRepository.Update(quiz);
        await _repositoryManager.Save();
        
        return new UpdateQuizCommandResult
        {
            Message = $"Викторина {quiz.Name} обновлена"
        };
    }
}
