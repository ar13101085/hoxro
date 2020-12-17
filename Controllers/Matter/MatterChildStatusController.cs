using System.Threading.Tasks;
using Hoxro.CQRS.Matter.GetMatterList;
using Hoxro.CQRS.Matter.GetMatterChildStatusList;
using Hoxro.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hoxro.Controllers
{
    public class MatterChildStatusController: Controller
    {
        private readonly IMediator _mediator;

        public MatterChildStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/MatterChildStatus/{pageId}")]
        public async Task<IActionResult> GetMatterChildStatusList(int pageId)
        {
            var cmd=new GetMatterChildStatusListCmd()
            {
                UserRequestCmd = new GetMatterChildStatusListCmdModel()
                {
                    Page = pageId
                }
            };
            var result = new DefaultPayloadModel<GetMatterChildStatusListCmdResponse>()
            {
                Status = true,
                Message = "",
                Result = await _mediator.Send(cmd)
            };
            return Ok(result);
        }
    }
}