using System.Collections.Generic;

namespace Hoxro.CQRS.Matter.GetMatterTypeList
{
    public class GetMatterTypeListCmdResponse
    {
        public List<Models.MatterType> Matters { get; set; }
    }
}