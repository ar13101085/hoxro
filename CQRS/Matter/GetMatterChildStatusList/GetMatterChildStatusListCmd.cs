using Hoxro.CQRS.Matter.GetMatterList;
using MediatR;

namespace Hoxro.CQRS.Matter.GetMatterChildStatusList
{
    public class GetMatterChildStatusListCmd:IRequest<GetMatterChildStatusListCmdResponse>
    {
        public GetMatterChildStatusListCmdModel UserRequestCmd { get; set; }
    }
}