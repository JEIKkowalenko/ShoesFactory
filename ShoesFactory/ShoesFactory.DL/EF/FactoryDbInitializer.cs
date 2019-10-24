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
            db.Materials.Add(new Material("Шкіра", "Звичайна шкіра", 10));
            //db.Employers.Add(new Employer("Петро", "Перший", "Працівник"));
            //db.Sexes.Add(new Sex( "Чоловіча", new List<int>() { 12,11, 10, 9}));
            //db.Shoes.Add();
            db.SaveChanges();
        }
    }
}
