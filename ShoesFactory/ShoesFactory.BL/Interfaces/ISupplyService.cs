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
        void AddSupply(MaterialDTO material, string supplierName, int materialCount, double price);
        SupplyDTO GetSupply(int? id);
        IEnumerable<SupplyDTO> GetAllSupplies();
        void DeleteSupply(int id);
        void AddMaterial(MaterialDTO material);
        MaterialDTO GetMaterial(int? id);
        IEnumerable<MaterialDTO> GetAllMaterials();
        void DeleteMaterial(int id);
        void UpdateMaterial(MaterialDTO material);
        void AddSupplier(SupplierDTO supplier);
        SupplierDTO GetSupplier(int? id);
        IEnumerable<SupplierDTO> GetAllSuppliers();
        void DeleteSupplier(int id);
        void Dispose();
    }
}
