using MediatR;

namespace Hoxro.CQRS.Matter.GetWorkTypeList
{
    public class GetWorkTypeListCmd:IRequest<GetWorkTypeListCmdResponse>
    {
        public GetWorkTypeListCmdModel UserRequestCmd { get; set; }
    }
}