﻿using ShoesFactory.DAL.EF;
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

        public EFUnitOfWork( string connectionString)
        {
            db = new ShoesContext(connectionString);
        }
        public IRepository<Shoes> Shoes => throw new NotImplementedException();

        public IRepository<Element> Elements => throw new NotImplementedException();

        public IRepository<Employer> Employers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Material> Materials {
            get
            {
                if(materialRepository == null)
                {
                    materialRepository = new MaterialRepository(db);              
                }
                return materialRepository;
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