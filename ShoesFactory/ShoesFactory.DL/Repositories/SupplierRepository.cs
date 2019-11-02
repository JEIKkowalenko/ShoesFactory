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
    public class SupplierRepository : IRepository<Supplier>
    {
        ShoesContext db;
        public SupplierRepository(ShoesContext context)
        {
            db = context;
        }

        public void Create(Supplier item)
        {
            db.Suppliers.Add(item);
        }

        public void Delete(int id)
        {
            Supplier supplier = db.Suppliers.Find(id);
            if(supplier != null)
            {
                db.Suppliers.Remove(supplier);
            }
            
        }

        public IEnumerable<Supplier> Find(Func<Supplier, bool> predicate)
        {
            return db.Suppliers.Where(predicate).ToList();
        }

        public Supplier Get(int id)
        {
            return db.Suppliers.Find(id);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return db.Suppliers;
        }

        public void Update(Supplier supplier)
        {
            db.Entry(supplier).State = EntityState.Modified;
        }
    }
}
