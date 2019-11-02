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
    public class СonsignmentRepository : IRepository<Сonsignment>
    {
        ShoesContext db;
        public СonsignmentRepository(ShoesContext context)
        {
            db = context;
        }

        public void Create(Сonsignment item)
        {
            db.Сonsignments.Add(item);
        }

        public void Delete(int id)
        {
            Сonsignment consignment = db.Сonsignments.Find(id);
            if (consignment != null)
            {
                db.Сonsignments.Remove(consignment);
            }

        }

        public IEnumerable<Сonsignment> Find(Func<Сonsignment, bool> predicate)
        {
            return db.Сonsignments.Where(predicate).ToList();
        }

        public Сonsignment Get(int id)
        {
            return db.Сonsignments.Find(id);
        }

        public IEnumerable<Сonsignment> GetAll()
        {
            return db.Сonsignments;
        }

        public void Update(Сonsignment consignment)
        {
            db.Entry(consignment).State = EntityState.Modified;
        }
    }
}
