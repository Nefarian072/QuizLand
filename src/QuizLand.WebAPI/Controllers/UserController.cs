using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using QuizLand.WebAPI.Models.UserModels;
using QuizLandInfrastructure.Requests.Users.Commands;
using QuizLandInfrastructure.Requests.Users.Queries;
using QuizLandInfrastructure.Responses.Users.Commands;

namespace QuizLand.WebAPI.Controllers;

[Route("/[Controller]")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public UserController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserModel create)
    {
        var command = _mapper.Map<CreateUserCommand>(create);
        var result = await _mediator.Send(command);
        return Ok(_mapper.Map<CreateUserCommandResult>(result));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var result = await _mediator.Send(new GetAllUsersQuery());
        _mapper.Map<AllUsers>(result);
        return Ok(result);
    }
}

