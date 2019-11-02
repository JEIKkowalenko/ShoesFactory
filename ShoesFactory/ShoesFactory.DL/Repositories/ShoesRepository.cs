using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesFactory.DAL.Interfaces;
using ShoesFactory.DAL.Entities;
using ShoesFactory.DAL.EF;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace ShoesFactory.DAL.Repositories
{
    public class ShoesRepository : IRepository<Shoes>
    {
        ShoesContext db;
        public ShoesRepository(ShoesContext context)
        {
            db = context;
        }

        public void Create(Shoes item)
        {
            db.Shoes.Add(item);
        }

        public void Delete(int id)
        {
            Shoes shoes = db.Shoes.Find(id);
            if(shoes != null)
            {
                db.Shoes.Remove(shoes);
            }
            
        }

        public IEnumerable<Shoes> Find(Func<Shoes, bool> predicate)
        {
            return db.Shoes.Where(predicate).ToList();
        }

        public Shoes Get(int id)
        {
            return db.Shoes.Find(id);
        }

        public IEnumerable<Shoes> GetAll()
        {
            return db.Shoes;
        }

        public void Update(Shoes shoes)
        {
            db.Entry(shoes).State = EntityState.Modified;
        }
    }
}
