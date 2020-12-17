using System.Collections.Generic;

namespace Hoxro.CQRS.Matter.GetMatterStatusList
{
    public class GetMatterStatusListCmdResponse
    {
        public List<Models.MatterStatus> Matters { get; set; }
    }
}