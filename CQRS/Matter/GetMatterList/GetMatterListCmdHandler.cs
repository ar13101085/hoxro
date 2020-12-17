using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hoxro.Data;
using MediatR;

namespace Hoxro.CQRS.Matter.GetMatterList
{
    public class GetMatterListCmdHandler:IRequestHandler<GetMatterListCmd,GetMatterListCmdResponse>
    {
        private readonly ApplicationDbContext _db;
        public GetMatterListCmdHandler(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public Task<GetMatterListCmdResponse> Handle(GetMatterListCmd request, CancellationToken cancellationToken)
        {
            var pageId = request.UserRequestCmd.Page;
            if(pageId==0)
                throw new Exception("Invalid page id.");
            pageId = pageId-1;
            
            var allMatter = _db.Matter.Skip(10 * request.UserRequestCmd.Page).Take(10).ToList();
            GetMatterListCmdResponse response = new GetMatterListCmdResponse()
            {
                Matters = allMatter
            };
            return Task.FromResult(response);
        }
    }
}