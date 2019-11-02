using ShoesFactory.DAL.EF;
using ShoesFactory.DAL.Entities;
using ShoesFactory.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Repositories
{
    public class SupplyRepository : IRepository<Supply>
    {
        ShoesContext db;
        public SupplyRepository(ShoesContext context)
        {
            db = context;
        }

        public void Create(Supply item)
        {
            db.Supplies.Add(item);
        }

        public void Delete(int id)
        {
            Supply supply = db.Supplies.Find(id);
            if (supply != null)
            {
                db.Supplies.Remove(supply);
            }

        }

        public IEnumerable<Supply> Find(Func<Supply, bool> predicate)
        {
            return db.Supplies.Where(predicate).ToList();
        }

        public Supply Get(int id)
        {
            return db.Supplies.Find(id);
        }

        public IEnumerable<Supply> GetAll()
        {
            return db.Supplies;
        }

        public void Update(Supply supply)
        {
            db.Entry(supply).State = EntityState.Modified;
        }
    }
}
