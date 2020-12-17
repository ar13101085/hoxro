using System.Threading.Tasks;
using Hoxro.CQRS.Matter.GetMatterList;
using Hoxro.CQRS.Matter.GetBillingTypeList;
using Hoxro.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hoxro.Controllers
{
    public class BillingTypeController: Controller
    {
        private readonly IMediator _mediator;

        public BillingTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/BillingType/{pageId}")]
        public async Task<IActionResult> GetBillingTypeList(int pageId)
        {
            var cmd=new GetBillingTypeListCmd()
            {
                UserRequestCmd = new GetBillingTypeListCmdModel()
                {
                    Page = pageId
                }
            };
            var result = new DefaultPayloadModel<GetBillingTypeListCmdResponse>()
            {
                Status = true,
                Message = "",
                Result = await _mediator.Send(cmd)
            };
            return Ok(result);
        }
    }
}