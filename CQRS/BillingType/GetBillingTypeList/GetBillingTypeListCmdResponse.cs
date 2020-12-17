using System.Collections.Generic;

namespace Hoxro.CQRS.Matter.GetBillingTypeList
{
    public class GetBillingTypeListCmdResponse
    {
        public List<Models.BillingType> BillingTypeses { get; set; }
    }
}