using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.WEB.Models
{
    public class SupplierViewModel
    {
        public SupplierViewModel()
        {
        }

        public SupplierViewModel(string name)
        {
            Name = name;
        }

        public SupplierViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
