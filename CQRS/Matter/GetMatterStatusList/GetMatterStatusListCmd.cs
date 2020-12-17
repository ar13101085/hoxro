using Hoxro.CQRS.Matter.GetMatterList;
using MediatR;

namespace Hoxro.CQRS.Matter.GetMatterStatusList
{
    public class GetMatterStatusListCmd:IRequest<GetMatterStatusListCmdResponse>
    {
        public GetMatterStatusListCmdModel UserRequestCmd { get; set; }
    }
}