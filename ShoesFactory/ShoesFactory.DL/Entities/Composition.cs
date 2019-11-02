using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class Composition
    {
        public Composition()
        {
        }

        public Composition(int count, Shoes shoes, Material material)
        {
            Count = count;
            Shoes = shoes;
            Material = material;
        }

        public int Id { get; set; }
        public int Count { get; set; }
        public int? ShoesId { get; set; }
        public virtual Shoes Shoes { get; set; }
        public int? MaterialId { get; set; }
        public virtual Material Material { get; set; }
    }
}
