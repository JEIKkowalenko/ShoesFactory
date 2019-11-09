using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.BLL.DTO
{
    public class SupplierDTO
    {
        public SupplierDTO()
        {
        }

        public SupplierDTO(string name)
        {
            Name = name;
        }

        public SupplierDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
