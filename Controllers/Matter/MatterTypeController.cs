using System.Threading.Tasks;
using Hoxro.CQRS.Matter.GetMatterList;
using Hoxro.CQRS.Matter.GetMatterTypeList;
using Hoxro.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hoxro.Controllers
{
    public class MatterTypeController: Controller
    {
        private readonly IMediator _mediator;

        public MatterTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/MatterType/{pageId}")]
        public async Task<IActionResult> GetMatterTypeList(int pageId)
        {
            var cmd=new GetMatterTypeListCmd()
            {
                UserRequestCmd = new GetMatterTypeListCmdModel()
                {
                    Page = pageId
                }
            };
            var result = new DefaultPayloadModel<GetMatterTypeListCmdResponse>()
            {
                Status = true,
                Message = "",
                Result = await _mediator.Send(cmd)
            };
            return Ok(result);
        }
    }
}