using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace QuizLand.WebAPI.Controllers.UserControllers.GetAllUserController;

public class GetAllUsersController : Controller
{
    private readonly IMediator _mediator;
    public GetAllUsersController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllUsers(GetAllUsersModel getAll)
    {
        var result = await _mediator.Send(getAll);
        return Ok(result);
    }
}
