using CQRS.Data.model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.cqrs.command
{
   public record insert_item_command(items Items):IRequest<items>;
    
}
