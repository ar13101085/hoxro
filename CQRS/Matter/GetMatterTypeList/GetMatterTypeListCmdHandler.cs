using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hoxro.Data;
using MediatR;

namespace Hoxro.CQRS.Matter.GetMatterTypeList
{
    public class GetMatterTypeListCmdHandler:IRequestHandler<GetMatterTypeListCmd,GetMatterTypeListCmdResponse>
    {
        private readonly ApplicationDbContext _db;
        public GetMatterTypeListCmdHandler(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public Task<GetMatterTypeListCmdResponse> Handle(GetMatterTypeListCmd request, CancellationToken cancellationToken)
        {
            var pageId = request.UserRequestCmd.Page;
            if(pageId<=0)
                throw new Exception("Invalid page id.");
            pageId = pageId-1;
            
            var allMatter = _db.MatterType.Skip(10 * request.UserRequestCmd.Page).Take(10).ToList();
            GetMatterTypeListCmdResponse response = new GetMatterTypeListCmdResponse()
            {
                Matters = allMatter
            };
            return Task.FromResult(response);
        }
    }
}