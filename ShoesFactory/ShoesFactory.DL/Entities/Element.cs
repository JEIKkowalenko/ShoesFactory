using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public IEnumerable<Material> Materials { get; set; }
        public double Price { get; set; }
    }
}
