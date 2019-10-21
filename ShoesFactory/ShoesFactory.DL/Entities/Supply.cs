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
        public Supply(int count, Supplier supplier, Material material)
        {
            Count = count;
            Date = DateTime.Now;
            Supplier = supplier;
            Material = material;
        }

        public int Id { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int? MaterialId { get; set; }
        public Material Material { get; set; }

    }
}
