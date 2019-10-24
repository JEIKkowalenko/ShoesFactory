using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesFactory.DAL.Entities;

namespace ShoesFactory.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Employer> Employers { get; }
        IRepository<Material> Materials { get; }
        IRepository<Size> Sexes { get;}
        IRepository<Shoes> Shoes { get; }
        IRepository<Supplier> Suppliers { get; }
        IRepository<Supply> Supplies { get; }
        IRepository<Сonsignment> Сonsignments { get; }
        void Save();
    }
}
