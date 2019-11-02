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
    public class CompositionRepository : IRepository<Composition>
    {
        ShoesContext db;
        public CompositionRepository(ShoesContext context)
        {
            db = context;
        }

        public void Create(Composition item)
        {
            db.Compositions.Add(item);
        }

        public void Delete(int id)
        {
            Composition composition = db.Compositions.Find(id);
            if (composition != null)
            {
                db.Compositions.Remove(composition);
            }

        }

        public IEnumerable<Composition> Find(Func<Composition, bool> predicate)
        {
            return db.Compositions.Where(predicate).ToList();
        }

        public Composition Get(int id)
        {
            return db.Compositions.Find(id);
        }

        public IEnumerable<Composition> GetAll()
        {
            return db.Compositions;
        }

        public void Update(Composition composition)
        {
            db.Entry(composition).State = EntityState.Modified;
        }
    }
}
