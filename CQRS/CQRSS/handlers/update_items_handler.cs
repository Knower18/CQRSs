using CQRS.CQRSS.command;
using CQRS.Data;
using CQRS.Data.model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.CQRSS.handlers
{
    public class update_items_handler : IRequestHandler<update_item_command, bool>
    {
        appcontext db;
        public update_items_handler(appcontext data)
        {
            db = data;
            
        }
        public async Task<bool> Handle(update_item_command request, CancellationToken cancellationToken)
        {
            var found = await db.items.FindAsync(request.Items.id);
            if (found != null)
            {
               
                found.name = request.Items.name;
            }
            await db.SaveChangesAsync();
            return true;
        }
    }
}
