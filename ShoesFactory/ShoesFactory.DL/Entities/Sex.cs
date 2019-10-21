using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class Sex
    {
        public Sex()
        {
            Sizes = new List<int>();
        }

        public Sex(string name, Shoes shoes, ICollection<int> sizes)
        {
            Name = name;
            Sizes = sizes;
            Shoes = shoes;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<int> Sizes { get; set; }
        public Shoes Shoes { get; set; }
    }
}
