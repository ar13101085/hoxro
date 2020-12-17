using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hoxro.Data;
using MediatR;

namespace Hoxro.CQRS.Matter.GetMatterChildStatusList
{
    public class GetMatterChildStatusListCmdHandler:IRequestHandler<GetMatterChildStatusListCmd,GetMatterChildStatusListCmdResponse>
    {
        private readonly ApplicationDbContext _db;
        public GetMatterChildStatusListCmdHandler(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public Task<GetMatterChildStatusListCmdResponse> Handle(GetMatterChildStatusListCmd request, CancellationToken cancellationToken)
        {
            var pageId = request.UserRequestCmd.Page;
            if(pageId<=0)
                throw new Exception("Invalid page id.");
            pageId = pageId-1;
            
            var allMatter = _db.MatterChildStatus.Skip(10 * request.UserRequestCmd.Page).Take(10).ToList();
            GetMatterChildStatusListCmdResponse response = new GetMatterChildStatusListCmdResponse()
            {
                MatterChildStatus = allMatter
            };
            return Task.FromResult(response);
        }
    }
}