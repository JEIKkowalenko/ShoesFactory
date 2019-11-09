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

        public Material(string name, string summary, int count) : this(name, summary)
        {
            Count = count;
        }

        public Material(int id, string name, string summary, int count)
        {
            Id = id;
            Name = name;
            Summary = summary;
            Count = count;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Supply> Supplies { get; set; }

    }
}
