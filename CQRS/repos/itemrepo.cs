using CQRS.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.repos
{
    public interface itemrepo
    {
        public List<items> GetItems();
        public items GetItem(int id);
        public void insert(items item);
        public void delete(items item);
        public void update(items item);
    }
}
