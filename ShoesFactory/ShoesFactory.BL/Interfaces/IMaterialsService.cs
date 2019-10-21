using ShoesFactory.BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.BL.Interfaces
{
    public interface IMaterialsService
    {
        void AddMaterial(MaterialDTO materialDTO);
        MaterialDTO GetMaterial(int? id);
        IEnumerable<MaterialDTO> GetMaterials();
        void Dispose();
    }
}
