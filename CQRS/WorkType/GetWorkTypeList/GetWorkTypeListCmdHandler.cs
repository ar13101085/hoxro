using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Hoxro.Data;
using MediatR;

namespace Hoxro.CQRS.Matter.GetWorkTypeList
{
    public class GetWorkTypeListCmdHandler:IRequestHandler<GetWorkTypeListCmd,GetWorkTypeListCmdResponse>
    {
        private readonly ApplicationDbContext _db;
        public GetWorkTypeListCmdHandler(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public Task<GetWorkTypeListCmdResponse> Handle(GetWorkTypeListCmd request, CancellationToken cancellationToken)
        {
            var pageId = request.UserRequestCmd.Page;
            if(pageId<=0)
                throw new Exception("Invalid page id.");
            pageId = pageId-1;
            
            var allMatter = _db.WorkType.Skip(10 * request.UserRequestCmd.Page).Take(10).ToList();
            GetWorkTypeListCmdResponse response = new GetWorkTypeListCmdResponse()
            {
                WorkTypes = allMatter
            };
            return Task.FromResult(response);
        }
    }
}