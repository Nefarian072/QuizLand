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

namespace QuizLand.Infrastructure.Handlers.Quizes.Commands;

public class DeleteQuizCommandHandler: IRequestHandler<DeleteQuizCommand, DeleteQuizCommandResult>
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    public DeleteQuizCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public async Task<DeleteQuizCommandResult> Handle(DeleteQuizCommand request, CancellationToken cancellationToken)
    {
        var quiz = await _repositoryManager.QuizRepository.GetQuizWithQuestions(request.QuizId);
        if (quiz == null)
        {
            return new DeleteQuizCommandResult
            {
                Message = "Викторина не найдена"
            };
        }
        await _repositoryManager.QuizRepository.Delete(quiz.Id);
        await _repositoryManager.Save();
        return new DeleteQuizCommandResult
        {
            Message = "Викторина удалена"
        };
    }
}
