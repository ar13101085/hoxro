using Hoxro.CQRS.Matter.GetMatterList;
using MediatR;

namespace Hoxro.CQRS.Matter.GetMatterTypeList
{
    public class GetMatterTypeListCmd:IRequest<GetMatterTypeListCmdResponse>
    {
        public GetMatterTypeListCmdModel UserRequestCmd { get; set; }
    }
}