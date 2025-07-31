using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.repos
{
   public interface emailservice
    {
        public Task sendemail(string mail, string sub, string bod);
    }
}
