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

            return new SupplyDTO ( supply.Id, supply.Count, supply.Date, supply.SupplierId, supply.MaterialId);
        }

        public IEnumerable<SupplyDTO> GetAllSupplies()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Supply, SupplyDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Supply>, List<SupplyDTO>>(Database.Supplies.GetAll());
        }

        public void DeleteSupply(int id)
        {
            Database.Supplies.Delete(id);
            Database.Save();
        }

        public IEnumerable<MaterialDTO> GetAllMaterials()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Material, MaterialDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Material>, List<MaterialDTO>>(Database.Materials.GetAll());
        }
        public MaterialDTO GetMaterial(int? id)
        {
            if (id == null)
                throw new ValidationException("Id is empty", "");
            var material = Database.Materials.Get(id.Value);
            if (material == null)
                throw new ValidationException("Supply not found", "");

            return new MaterialDTO() {  Id = material.Id, Count = material.Count, Name = material.Name, Summary = material.Summary};
        }
        public void AddMaterial(MaterialDTO material)
        {
            Material oldMaterial = Database.Materials.Get(material.Id);
            if(oldMaterial != null)
            {
                oldMaterial.Name = material.Name;
                oldMaterial.Summary = material.Summary;
                oldMaterial.Count = material.Count;
                Database.Materials.Update(oldMaterial);
                Database.Save();
            }
            else
            {
                Database.Materials.Create(new Material(material.Id, material.Name, material.Summary, material.Count));
                Database.Save();
            }
            
        }

        public void UpdateMaterial(MaterialDTO newMaterial)
        {
            var oldMaterial = Database.Materials.Get(newMaterial.Id);
            if(oldMaterial != null)
            {
                Database.Materials.Update(new Material(newMaterial.Name, newMaterial.Summary, newMaterial.Count));
                Database.Save();
            }
            
        }
        public void DeleteMaterial(int id)
        {
            Database.Materials.Delete(id);
            Database.Save();
        }

        public IEnumerable<SupplierDTO> GetAllSuppliers()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Supplier, SupplierDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Supplier>, List<SupplierDTO>>(Database.Suppliers.GetAll());
        }
        public SupplierDTO GetSupplier(int? id)
        {
            if (id == null)
                throw new ValidationException("Id is empty", "");
            var supplier = Database.Suppliers.Get(id.Value);
            if (supplier == null)
                throw new ValidationException("Supply not found", "");

            return new SupplierDTO() { Id = supplier.Id, Name = supplier.Name};
        }
        public void AddSupplier(SupplierDTO supplier)
        {
            Supplier oldsupplier = Database.Suppliers.Get(supplier.Id);
            if (oldsupplier != null)
            {
                oldsupplier.Name = supplier.Name;
                Database.Suppliers.Update(oldsupplier);
                Database.Save();
            }
            else
            {
                Database.Suppliers.Create(new Supplier() { Name = supplier.Name});
                Database.Save();
            }

        }
        public void DeleteSupplier(int id)
        {
            Database.Suppliers.Delete(id);
            Database.Save();
        }
    }
}
