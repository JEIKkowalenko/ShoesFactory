using ShoesFactory.DAL.EF;
using ShoesFactory.DAL.Entities;
using ShoesFactory.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ShoesContext db;
        private MaterialRepository materialRepository;
        private CompositionRepository compositionRepository;
        private EmployerRepository employerRepository;
        private ShoesRepository shoesRepository;
        private SizeRepository sizeRepository;
        private SupplierRepository supplierRepository;
        private SupplyRepository supplyRepository;
        private TableOfDimensionRepository tableOfDimensionRepository;
        private СonsignmentRepository consignmentRepository;

        public EFUnitOfWork( string connectionString)
        {
            db = new ShoesContext(connectionString);
        }
        public IRepository<Employer> Employers {
            get
            {
                if (employerRepository == null)
                    employerRepository = new EmployerRepository(db);
                return employerRepository;
            }
        }

        public IRepository<Material> Materials{
            get
            {
                if (materialRepository == null)
                    materialRepository = new MaterialRepository(db);
                return materialRepository;
            }
        }

        public IRepository<Size> Sizes {
            get
            {
                if (sizeRepository == null)
                    sizeRepository = new SizeRepository(db);
                return sizeRepository;
            }
        }

        public IRepository<Shoes> Shoes {
            get
            {
                if (shoesRepository == null)
                    shoesRepository = new ShoesRepository(db);
                return shoesRepository;
            }
        }

        public IRepository<Supplier> Suppliers {
            get
            {
                if (supplierRepository == null)
                    supplierRepository = new SupplierRepository(db);
                return supplierRepository;
            }
        }

        public IRepository<Supply> Supplies {
            get
            {
                if (supplyRepository == null)
                    supplyRepository = new SupplyRepository(db);
                return supplyRepository;
            }
        }

        public IRepository<Сonsignment> Сonsignments {
            get
            {
                if (consignmentRepository == null)
                    consignmentRepository = new СonsignmentRepository(db);
                return consignmentRepository;
            }
        }

        public IRepository<Composition> Compositions {
            get
            {
                if (compositionRepository == null)
                    compositionRepository = new CompositionRepository(db);
                return compositionRepository;
            }
        }

        public IRepository<TableOfDimension> TablesOfDimension
        {
            get
            {
                if (tableOfDimensionRepository == null)
                    tableOfDimensionRepository = new TableOfDimensionRepository(db);
                return tableOfDimensionRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposedValue = false;   

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
