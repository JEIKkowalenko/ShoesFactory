using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.WEB.Models
{
    public class SupplyViewModel
    {
        public SupplyViewModel()
        {
        }
       
        public SupplyViewModel(string materialName, string supplierName, int count, double price)
        {
            MaterialName = materialName;
            SupplierName = supplierName;
            Count = count;
            Price = price;
        }
        public int Id { get; set; }
        public  string SupplierName { get; set; }
        public string MaterialName { get; set; }
        public int MaterialId { get; set; }
        public int SupplierId { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }       
    }
}
