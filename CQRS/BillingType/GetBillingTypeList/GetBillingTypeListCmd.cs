using MediatR;

namespace Hoxro.CQRS.Matter.GetBillingTypeList
{
    public class GetBillingTypeListCmd:IRequest<GetBillingTypeListCmdResponse>
    {
        public GetBillingTypeListCmdModel UserRequestCmd { get; set; }
    }
}