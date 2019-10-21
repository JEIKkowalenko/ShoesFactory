using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.BL.DTO
{
    public class ElementDTO
    {
        public ElementDTO(string name, string summary, IEnumerable<MaterialDTO> materials, double price)
        {
            Name = name;
            Summary = summary;
            Materials = materials;
            Price = price;
        }

        public ElementDTO()
        {
            Materials = new List<MaterialDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public IEnumerable<MaterialDTO> Materials { get; set; }
        public double Price { get; set; }
    }
}
