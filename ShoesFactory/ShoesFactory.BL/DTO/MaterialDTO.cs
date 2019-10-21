using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.BL.DTO
{
    public class MaterialDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public int? ElementDTOId { get; set; }
        public MaterialDTO()
        {

        }
        public MaterialDTO(string name, string summary, int count, double price)
        {
            Name = name;
            Summary = summary;
            Count = count;
            Price = price;
        }
    }
}
