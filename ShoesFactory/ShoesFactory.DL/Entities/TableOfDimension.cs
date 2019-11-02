using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class TableOfDimension
    {
        public TableOfDimension()
        {
        }

        public TableOfDimension(int count, Size size, Shoes shoes)
        {
            Count = count;
            Size = size;
            Shoes = shoes;
        }

        public int Id { get; set; }
        public int Count { get; set; }
        public int? SizeId { get; set; }
        public virtual Size Size { get; set; }
        public int? ShoesId { get; set; }
        public virtual Shoes Shoes { get; set; }

    }
}
