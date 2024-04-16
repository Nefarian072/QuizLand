using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace QuizLand.WebAPI.Controllers.UserControllers.CreateUserController;

public class CreateUserController : Controller
{
    private readonly IMediator _mediator;

    public CreateUserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserModel create) // не уверен что стоит называть экзмепляр именно create
    {
        var result = await _mediator.Send(create);
        return Ok(result);
    }
}
