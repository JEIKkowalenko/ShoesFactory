using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class Supply
    {
        public Supply()
        {

        }
        public Supply(Supplier supplier, Material material, int count)
        {
            Supplier = supplier;
            Material = material;
            Count = count;
            Date = DateTime.Now;
        }
        public Supply(Supplier supplier, Material material, int count, double price)
        {
            Supplier = supplier;
            Material = material;
            Count = count;
            Date = DateTime.Now;
            Price = price;
        }

        public int Id { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public int? SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int? MaterialId { get; set; }
        public virtual Material Material { get; set; }

    }
}
