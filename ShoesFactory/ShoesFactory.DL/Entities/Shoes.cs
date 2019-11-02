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
            TablesOfDimensions = new List<TableOfDimension>();
        }
        public Shoes( string name, string summary)
        {
            Name = name;
            Summary = summary;
            Materials = new List<Material>();
            Сonsignments = new List<Сonsignment>();
            TablesOfDimensions = new List<TableOfDimension>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }       
        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<Сonsignment> Сonsignments { get; set; }
        public virtual ICollection<TableOfDimension> TablesOfDimensions { get; set; }
    }
}
