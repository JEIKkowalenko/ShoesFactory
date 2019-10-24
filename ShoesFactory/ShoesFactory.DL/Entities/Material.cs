using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class Material
    {
        public Material()
        {
            Supplies = new List<Supply>();
        }

        public Material(string name, string summary)
        {
            Name = name;
            Summary = summary;
            Supplies = new List<Supply>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public ICollection<Supply> Supplies { get; set; }

    }
}
