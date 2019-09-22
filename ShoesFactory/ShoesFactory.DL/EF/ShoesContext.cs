using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShoesFactory.DAL.Entities;

namespace ShoesFactory.DAL.EF
{
    public class ShoesContext : DbContext
    {
        public ShoesContext()
        {
            Database.SetInitializer<ShoesContext>(new ShoesFactoryDbInitializer());
        }
        public ShoesContext(string connectionString) : base(connectionString)
        {

        }
        public DbSet<Material> Materials { get; set; }

    }
}
