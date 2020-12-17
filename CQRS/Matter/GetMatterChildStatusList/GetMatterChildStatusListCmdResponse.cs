using System.Collections.Generic;

namespace Hoxro.CQRS.Matter.GetMatterChildStatusList
{
    public class GetMatterChildStatusListCmdResponse
    {
        public List<Models.MatterChildStatus> MatterChildStatus { get; set; }
    }
}