using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBrand.Application.UseCases.Users.Commands;

namespace PersonalBrand.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentitiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IdentitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Rergister(CreateUserCommand createUserCommand)
        {
            var result = await _mediator.Send(createUserCommand);

            return Ok(result);
        }
    }
}
