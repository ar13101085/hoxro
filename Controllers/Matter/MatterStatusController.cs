using System.Threading.Tasks;
using Hoxro.CQRS.Matter.GetMatterList;
using Hoxro.CQRS.Matter.GetMatterStatusList;
using Hoxro.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hoxro.Controllers
{
    public class MatterStatusController: Controller
    {
        private readonly IMediator _mediator;

        public MatterStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/MatterStatus/{pageId}")]
        public async Task<IActionResult> GetMatterStatusList(int pageId)
        {
            var cmd=new GetMatterStatusListCmd()
            {
                UserRequestCmd = new GetMatterStatusListCmdModel()
                {
                    Page = pageId
                }
            };
            var result = new DefaultPayloadModel<GetMatterStatusListCmdResponse>()
            {
                Status = true,
                Message = "",
                Result = await _mediator.Send(cmd)
            };
            return Ok(result);
        }
    }
}