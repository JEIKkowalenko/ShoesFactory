using ShoesFactory.BL.DTO;
using ShoesFactory.BL.Interfaces;
using ShoesFactory.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.BL.Services
{
    public class MaterialService : IMaterialsService
    {
        IUnitOfWork Database { get; set; }
        public MaterialService(IUnitOfWork iuow)
        {
            Database = iuow;
        }

        public void AddMaterial(MaterialDTO materialDTO)
        {
            
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public MaterialDTO GetMaterial(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaterialDTO> GetMaterials()
        {
            throw new NotImplementedException();
        }
    }
}
