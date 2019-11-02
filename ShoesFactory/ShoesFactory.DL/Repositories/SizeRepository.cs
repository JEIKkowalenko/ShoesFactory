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
    public class SizeRepository : IRepository<Size>
    {
        ShoesContext db;
        public SizeRepository(ShoesContext context)
        {
            db = context;
        }

        public void Create(Size item)
        {
            db.Sizes.Add(item);
        }

        public void Delete(int id)
        {
            Size size = db.Sizes.Find(id);
            if(size != null)
            {
                db.Sizes.Remove(size);
            }
            
        }

        public IEnumerable<Size> Find(Func<Size, bool> predicate)
        {
            return db.Sizes.Where(predicate).ToList();
        }

        public Size Get(int id)
        {
            return db.Sizes.Find(id);
        }

        public IEnumerable<Size> GetAll()
        {
            return db.Sizes;
        }

        public void Update(Size size)
        {
            db.Entry(size).State = EntityState.Modified;
        }
    }
}
