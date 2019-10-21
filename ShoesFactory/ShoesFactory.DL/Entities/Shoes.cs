using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class Shoes
    {
        public Shoes()
        {
            Materials = new List<Material>();
            Сonsignments = new List<Сonsignment>();
        }
        public Shoes(int id, string name, string summary, int pairsCount, Sex sex)
        {
            Id = id;
            Name = name;
            Summary = summary;
            PairsCount = pairsCount;
            Materials = new List<Material>();
            Сonsignments = new List<Сonsignment>();
            Sex = sex;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }       
        public int PairsCount { get; set; }
        public ICollection<Material> Materials { get; set; }
        public int? SexId { get; set; }
        public Sex Sex { get; set; }
        public ICollection<Сonsignment> Сonsignments { get; set; }
    }
}
