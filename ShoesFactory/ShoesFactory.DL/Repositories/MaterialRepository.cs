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
    public class MaterialRepository : IRepository<Material>
    {
        ShoesContext db;
        public MaterialRepository(ShoesContext context)
        {
            db = context;
        }

        public void Create(Material item)
        {
            db.Materials.Add(item);
        }

        public void Delete(int id)
        {
            Material material = db.Materials.Find(id);
            if(material != null)
            {
                db.Materials.Remove(material);
            }
            
        }

        public IEnumerable<Material> Find(Func<Material, bool> predicate)
        {
            return db.Materials.Where(predicate).ToList();
        }

        public Material Get(int id)
        {
            return db.Materials.Find(id);
        }

        public IEnumerable<Material> GetAll()
        {
            return db.Materials;
        }

        public void Update(Material material)
        {
            db.Entry(material).State = EntityState.Modified;
        }
    }
}
