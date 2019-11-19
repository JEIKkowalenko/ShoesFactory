using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.BLL.DTO
{
    public class SupplyDTO
    {
        public SupplyDTO()
        {
        }
        public SupplyDTO(double price, int count, DateTime date, int? supplierId, int? materialId)
        {
            Price = price;
            Count = count;
            Date = date;
            SupplierId = supplierId;
            MaterialId = materialId;
        }

        public SupplyDTO(int count, DateTime date, int? supplierId, int? materialId)
        {
            Count = count;
            Date = date;
            SupplierId = supplierId;
            MaterialId = materialId;
        }

        public SupplyDTO(int id, int count, DateTime date, int? supplierId, int? materialId)
        {
            Id = id;
            Count = count;
            Date = date;
            SupplierId = supplierId;
            MaterialId = materialId;
        }

        public int Id { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public int? SupplierId { get; set; }
        public int? MaterialId { get; set; }
    }
}
