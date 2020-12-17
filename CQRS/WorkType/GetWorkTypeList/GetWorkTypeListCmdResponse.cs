using System.Collections.Generic;

namespace Hoxro.CQRS.Matter.GetWorkTypeList
{
    public class GetWorkTypeListCmdResponse
    {
        public List<Models.WorkType> WorkTypes { get; set; }
    }
}