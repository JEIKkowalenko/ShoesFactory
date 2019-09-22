using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ShoesFactory.DAL.EF
{
    public class ShoesFactoryDbInitializer : DropCreateDatabaseIfModelChanges<ShoesContext>
    {
        protected override void Seed(ShoesContext db)
        {
            
            db.SaveChanges();
        }
    }
}
