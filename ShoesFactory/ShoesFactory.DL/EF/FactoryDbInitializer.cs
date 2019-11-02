using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShoesFactory.DAL.Entities;

namespace ShoesFactory.DAL.EF
{
    public class ShoesFactoryDbInitializer : DropCreateDatabaseAlways<ShoesContext>
    {
        protected override void Seed(ShoesContext db)
        {
            var supplier = db.Suppliers.Add(new Supplier("Apple corp"));          
            var lether = db.Materials.Add(new Material("Lether", "Just lether"));
            db.Supplies.Add(new Supply(supplier, lether, 20));
            var shoes = db.Shoes.Add(new Shoes("Sneakers", "Adidas YUNG-1"));
            db.Compositions.Add(new Composition(10, shoes, lether));
            var size = db.Sizes.Add(new Size(11, 10, 44, "male"));
            db.TableOfDimensions.Add(new TableOfDimension(10, size, shoes));
            var employer = db.Employers.Add(new Employer("Yevhenii", "Kovalenko", "CEO"));
            db.Сonsignments.Add(new Сonsignment(shoes, employer, 149.5));
            db.SaveChanges();
        }
    }
}
