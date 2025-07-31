using CQRS.Data;
using CQRS.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.repos
{
    public class item_repo : itemrepo
    {
        private appcontext db;
        public item_repo()
        {
            
        }
        public item_repo( appcontext appcontext)
        {
            db= appcontext;
        }
        public void delete(items item)
        {
           var found = db.items.FirstOrDefault(o=>o.id==item.id);
            if (found != null) db.Remove(found);
            db.SaveChanges();
        }

        public items GetItem(int id)
        {
            var found=db.items.FirstOrDefault(o=>o.id==id);
            return found ?? new();
        }

        public List<items> GetItems()
        {
           return db.items.ToList();
        }

        public void insert(items item)
        {
          db.items.Add(item);
            db.SaveChanges();
        }

        public void update(items item)
        {
            db.items.Attach(item);
        }
    }
}
