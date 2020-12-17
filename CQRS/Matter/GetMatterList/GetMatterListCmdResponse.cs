using System.Collections.Generic;

namespace Hoxro.CQRS.Matter.GetMatterList
{
    public class GetMatterListCmdResponse
    {
        public List<Models.Matter> Matters { get; set; }
    }
}