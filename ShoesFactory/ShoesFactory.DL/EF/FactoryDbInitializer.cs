using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShoesFactory.DAL.Entities;

namespace ShoesFactory.DAL.EF
{
    public class ShoesFactoryDbInitializer : DropCreateDatabaseIfModelChanges<ShoesContext>
    {
        protected override void Seed(ShoesContext db)
        {
            db.Materials.Add(new Material("Lether", "Just fucking lether", 20, 12.3));
            db.SaveChanges();
        }
    }
}
