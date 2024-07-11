using Microsoft.AspNetCore.Mvc;
using MediatR;
using AutoMapper;
using QuizLand.WebAPI.Models.PointModels;
using QuizLand.Infrastructure.Requests.Points.Commands;
using QuizLand.Infrastructure.Responses.Points.Commands;

namespace QuizLand.WebAPI.Controllers;

[Route("/[Controller]")]
public class PlayController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public PlayController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost(nameof(RateAnswer))]
    public async Task<IActionResult> RateAnswer([FromBody] RateTheAnswerModel create)
    {
        var command = _mapper.Map<RateTheAnswerCommand>(create);
        command.ParticipantId = 1;// TODO: получать айди участника после реализации авторизации
        var result = await _mediator.Send(command);
        return Ok(_mapper.Map<RateTheAnswerCommandResult>(result));
    }
}
