using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hoxro.Data;
using MediatR;

namespace Hoxro.CQRS.Matter.GetMatterStatusList
{
    public class GetMatterStatusListCmdHandler:IRequestHandler<GetMatterStatusListCmd,GetMatterStatusListCmdResponse>
    {
        private readonly ApplicationDbContext _db;
        public GetMatterStatusListCmdHandler(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public Task<GetMatterStatusListCmdResponse> Handle(GetMatterStatusListCmd request, CancellationToken cancellationToken)
        {
            var pageId = request.UserRequestCmd.Page;
            if(pageId==0)
                throw new Exception("Invalid page id.");
            pageId = pageId-1;
            
            var allMatter = _db.MatterStatuses.Skip(10 * request.UserRequestCmd.Page).Take(10).ToList();
            GetMatterStatusListCmdResponse response = new GetMatterStatusListCmdResponse()
            {
                Matters = allMatter
            };
            return Task.FromResult(response);
        }
    }
}