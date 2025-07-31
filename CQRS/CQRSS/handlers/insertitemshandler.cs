using CQRS.cqrs.command;
using CQRS.Data;
using CQRS.Data.model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.cqrs.handlers
{
    public class insertitemshandler : IRequestHandler<insert_item_command, items>
    {
        appcontext db;
        public insertitemshandler(appcontext appcontext)
        {
            this.db=appcontext;
        }
        public async Task<items> Handle(insert_item_command request, CancellationToken cancellationToken)
        {
            
            await db.AddAsync(request.Items);
            db.SaveChanges();
            return await Task.FromResult(request.Items);
        }
    }
}
