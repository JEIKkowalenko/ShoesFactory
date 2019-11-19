using ShoesFactory.BLL.DTO;
using ShoesFactory.BLL.Interfaces;
using ShoesFactory.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesFactory.DAL.Entities;
using ShoesFactory.BLL.Infrastucture;
using AutoMapper;

namespace ShoesFactory.BLL.Services
{
    public class SupplyService : ISupplyService
    {
        IUnitOfWork Database { get; set; }
        public SupplyService(IUnitOfWork iuow)
        {
            Database = iuow;
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public void AddSupply(MaterialDTO material, string supplierName, int materialCount, double price)
        {
            Material oldMaterial = Database.Materials.Find(m => m.Name == material.Name).FirstOrDefault();
            Material newMaterial;
            Supplier oldSupplier = Database.Suppliers.Find(s => s.Name == supplierName).FirstOrDefault();
            Supplier newSupplier;

            if (oldMaterial == null)
            {
                newMaterial = new Material(material.Name, material.Summary);
                Database.Materials.Create(newMaterial);
            }
            else
            {
                oldMaterial.Summary = material.Summary;
                oldMaterial.Count = oldMaterial.Count + materialCount;
                Database.Materials.Update(oldMaterial);
                newMaterial = oldMaterial;
            }

            if (oldSupplier == null)
            {
                newSupplier = new Supplier(supplierName);
                Database.Suppliers.Create(newSupplier);
            }
            else
            {
                newSupplier = oldSupplier;
            }

            Database.Supplies.Create(new Supply(newSupplier,newMaterial, materialCount, price));
            Database.Save();
        }

        public SupplyDTO GetSupply(int? id)
        {
            if (id == null)
                throw new ValidationException("Id is empty", "");
            var supply = Database.Supplies.Get(id.Value);
            if (supply == null)
                throw new ValidationException("Supply not found", "");

            return new SupplyDTO (supply.Count, supply.Date, supply.SupplierId, supply.MaterialId);
        }

        public IEnumerable<SupplyDTO> GetAllSupplies()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Supply, SupplyDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Supply>, List<SupplyDTO>>(Database.Supplies.GetAll());
        }
    }
}
