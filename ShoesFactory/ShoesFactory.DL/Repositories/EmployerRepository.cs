using ShoesFactory.DAL.EF;
using ShoesFactory.DAL.Entities;
using ShoesFactory.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Repositories
{
    public class EmployerRepository : IRepository<Employer>
    {
        ShoesContext db;
        public EmployerRepository(ShoesContext context)
        {
            db = context;
        }

        public void Create(Employer item)
        {
            db.Employers.Add(item);
        }

        public void Delete(int id)
        {
            Employer employer = db.Employers.Find(id);
            if (employer != null)
            {
                db.Employers.Remove(employer);
            }

        }

        public IEnumerable<Employer> Find(Func<Employer, bool> predicate)
        {
            return db.Employers.Where(predicate).ToList();
        }

        public Employer Get(int id)
        {
            return db.Employers.Find(id);
        }

        public IEnumerable<Employer> GetAll()
        {
            return db.Employers;
        }

        public void Update(Employer employer)
        {
            db.Entry(employer).State = EntityState.Modified;
        }
    }
}
