using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesFactory.DAL.Entities;

namespace ShoesFactory.DL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Shoes> Shoes { get; }
        IRepository<Element> Elements { get; }
        IRepository<Employer> Employers { get; set; }
        IRepository<Material> Materials { get; set; }
        void Save();
    }
}
