using ShoesFactory.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.BLL.Interfaces
{
    public interface ISupplyService
    {
        void AddSupply(string materialName, string supplierName, int materialCount, double price);
        SupplyDTO GetSupply(int? id);
        IEnumerable<SupplyDTO> GetAllSupplies();
        void Dispose();
    }
}
