using CQRS.cqrs.querys;
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
    public class getitemshnadler : IRequestHandler<get__tems_query, List<items>>
    {
        appcontext db;
        public getitemshnadler( appcontext appcontext)
        {
            this.db= appcontext;
            
        }

        public async Task<List<items>> Handle(get__tems_query request, CancellationToken cancellationToken)
        {
            return await  Task.FromResult(db.items.ToList());
        }
    }
}

