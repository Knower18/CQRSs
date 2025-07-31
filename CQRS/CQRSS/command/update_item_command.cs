using CQRS.Data.model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.CQRSS.command
{
    public  record update_item_command(items Items):IRequest<bool>;
  
}
