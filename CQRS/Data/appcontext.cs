using CQRS.Data.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Data
{
    public  class appcontext:DbContext
    {
        public appcontext(DbContextOptions<appcontext> options):base(options) { }
        public  DbSet<items> items { get; set; }
        public DbSet<users> users { get; set; }
       
    }
}
