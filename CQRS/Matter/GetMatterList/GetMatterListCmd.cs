using MediatR;

namespace Hoxro.CQRS.Matter.GetMatterList
{
    public class GetMatterListCmd:IRequest<GetMatterListCmdResponse>
    {
        public GetMatterListCmdModel UserRequestCmd { get; set; }
    }
}