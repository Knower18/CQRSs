using CQRS.Data.model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.cqrs.querys
{
    public record get__tems_query:IRequest<List<items>>;
   
}
