using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using QuizLand.WebAPI.Models.QuizModels;
using QuizLand.Infrastructure.Requests.Quizes.Commands;
using QuizLand.Infrastructure.Responses.Quizes.Commands;
using QuizLand.Infrastructure.Requests.Quizes.Queries;
using QuizLand.Infrastructure.Responses.Quizes.Queries;
using QuizLand.DataLayer.Core.Entities;
using QuizLand.Infrastructure.Requests.Questions.Command;
using QuizLand.Infrastructure.Responses.Questions.Command;
using QuizLand.WebAPI.Models.QuestionModels;
namespace QuizLand.WebAPI.Controllers;

[Route("/[Controller]")]
public class QuizController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public QuizController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    [HttpPost]
    public async Task<IActionResult> CreateQuiz([FromBody] CreateQuizModel create)
    {
        var command = _mapper.Map<CreateQuizCommand>(create);
        var result = await _mediator.Send(command);
        return Ok(_mapper.Map<CreateQuizCommandResult>(result));
    }
    [HttpGet(nameof(GetQuizById))]
    public async Task<IActionResult> GetQuizById(GetQuizModel create)
    {
        var command = _mapper.Map<GetQuizQuery>(create);
        var result = await _mediator.Send(command);
        return Ok(_mapper.Map<GetQuizQueryResult>(result));
    }
    [HttpGet(nameof(GetFirstQuestion))]
    public async Task<IActionResult> GetFirstQuestion(GetQuizModel create)
    {
        var command = _mapper.Map<GetFirstQuestionQuery>(create);
        var result = await _mediator.Send(command);
        return Ok(_mapper.Map<GetFirstQuestionQueryResult>(result));
    }
    [HttpPost(nameof(DeleteQuiz))]
    public async Task<IActionResult> DeleteQuiz(GetQuizModel create)
    {
        var command = _mapper.Map<DeleteQuizCommand>(create);
        var result = await _mediator.Send(command);
        return Ok(_mapper.Map<DeleteQuizCommandResult>(result));
    }
    [HttpPost(nameof (UpdateQuiz))]
    public async Task<IActionResult> UpdateQuiz([FromBody] UpdateQuizModel create)
    {
        var command = _mapper.Map<UpdateQuizCommand>(create);
        var result = await _mediator.Send(command);
        return Ok(_mapper.Map<UpdateQuizCommandResult>(result));
    }

    [HttpPost(nameof (UpdateQuestion))]
    public async Task<IActionResult> UpdateQuestion([FromBody] UpdateQuestionModel create)
    {
        var command = _mapper.Map<UpdateQuestionCommand>(create);
        var result = await _mediator.Send(command);
        return Ok(_mapper.Map<UpdateQuestionCommandResult>(result));
    }
    [HttpGet(nameof(GetQuestions))]

    public async Task<IActionResult> GetQuestions(GetQuizModel create)
    {
        var command = _mapper.Map<GetQuestionsQuery>(create);
        var result = await _mediator.Send(command);
        return Ok(_mapper.Map<GetQuestionsQueryResult>(result));
    }
}
