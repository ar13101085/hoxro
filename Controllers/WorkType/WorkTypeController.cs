using System.Threading.Tasks;
using Hoxro.CQRS.Matter.GetMatterList;
using Hoxro.CQRS.Matter.GetWorkTypeList;
using Hoxro.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hoxro.Controllers
{
    public class WorkTypeController: Controller
    {
        private readonly IMediator _mediator;

        public WorkTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/WorkType/{pageId}")]
        public async Task<IActionResult> GetWorkTypeList(int pageId)
        {
            var cmd=new GetWorkTypeListCmd()
            {
                UserRequestCmd = new GetWorkTypeListCmdModel()
                {
                    Page = pageId
                }
            };
            var result = new DefaultPayloadModel<GetWorkTypeListCmdResponse>()
            {
                Status = true,
                Message = "",
                Result = await _mediator.Send(cmd)
            };
            return Ok(result);
        }
    }
}