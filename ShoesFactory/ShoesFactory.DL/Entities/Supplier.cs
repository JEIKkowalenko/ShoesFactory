using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class Supplier
    {
        public Supplier()
        {
            Supplies = new List<Supply>();
        }
        public Supplier(string name)
        {
            Name = name;
            Supplies = new List<Supply>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Supply> Supplies { get; set; }
    }
}
