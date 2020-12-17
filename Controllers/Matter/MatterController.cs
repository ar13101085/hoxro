using System.Threading.Tasks;
using Hoxro.CQRS.Matter.GetMatterList;
using Hoxro.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hoxro.Controllers
{
    public class MatterController: Controller
    {
        private readonly IMediator _mediator;

        public MatterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/Matter/{pageId}")]
        public async Task<IActionResult> GetMatterList(int pageId)
        {
            var cmd=new GetMatterListCmd()
            {
                UserRequestCmd = new GetMatterListCmdModel()
                {
                    Page = pageId
                }
            };
            var result = new DefaultPayloadModel<GetMatterListCmdResponse>()
            {
                Status = true,
                Message = "",
                Result = await _mediator.Send(cmd)
            };
            return Ok(result);
        }
    }
}