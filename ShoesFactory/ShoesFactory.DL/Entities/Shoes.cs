using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DL.Entities
{
    public class Shoes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Summary { get; set; }       
        public double Margin { get; set; }
        public IEnumerable<Element> Elements { get; set; }
    }
}
