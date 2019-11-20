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
    public class ShoesService 
    {
        IUnitOfWork Database { get; set; }
        public ShoesService(IUnitOfWork iuow)
        {
            Database = iuow;
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public void AddShoes(string name, string summary, IDictionary<int, int> materials)
        {
            //Materials is collection that contains key(Material Id) and value(Material count)
            
            foreach (var material in materials)
            {
                Material currentMaterial = Database.Materials.Find(m => m.Id == material.Key).FirstOrDefault();
                if (currentMaterial.Count > material.Value)
                {
                    currentMaterial.Count -= material.Value;
                    
                }
                else
                {
                    throw new Exception(Database.Materials.Find(m => m.Id == material.Key).FirstOrDefault().Name + " is not enough");
                }
            }
            Shoes newShoes = new Shoes(name, summary);

            Database.Shoes.Create(newShoes);

            foreach(var material in materials)
            {
                Database.Compositions.Create(new Composition(material.Value, Database.Shoes.Find(s => s.Name == name).FirstOrDefault(), Database.Materials.Get(material.Key)));
            }
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
