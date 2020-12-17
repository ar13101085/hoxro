using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hoxro.Data;
using MediatR;

namespace Hoxro.CQRS.Matter.GetBillingTypeList
{
    public class GetBillingTypeListCmdHandler:IRequestHandler<GetBillingTypeListCmd,GetBillingTypeListCmdResponse>
    {
        private readonly ApplicationDbContext _db;
        public GetBillingTypeListCmdHandler(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public Task<GetBillingTypeListCmdResponse> Handle(GetBillingTypeListCmd request, CancellationToken cancellationToken)
        {
            var pageId = request.UserRequestCmd.Page;
            if(pageId<=0)
                throw new Exception("Invalid page id.");
            pageId = pageId-1;
            
            var allMatter = _db.BillingTypes.Skip(10 * request.UserRequestCmd.Page).Take(10).ToList();
            GetBillingTypeListCmdResponse response = new GetBillingTypeListCmdResponse()
            {
                BillingTypeses = allMatter
            };
            return Task.FromResult(response);
        }
    }
}