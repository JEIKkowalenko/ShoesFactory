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
    public class TableOfDimensionRepository : IRepository<TableOfDimension>
    {
        ShoesContext db;
        public TableOfDimensionRepository(ShoesContext context)
        {
            db = context;
        }

        public void Create(TableOfDimension item)
        {
            db.TableOfDimensions.Add(item);
        }

        public void Delete(int id)
        {
            TableOfDimension tableOfDimension = db.TableOfDimensions.Find(id);
            if (tableOfDimension != null)
            {
                db.TableOfDimensions.Remove(tableOfDimension);
            }

        }

        public IEnumerable<TableOfDimension> Find(Func<TableOfDimension, bool> predicate)
        {
            return db.TableOfDimensions.Where(predicate).ToList();
        }

        public TableOfDimension Get(int id)
        {
            return db.TableOfDimensions.Find(id);
        }

        public IEnumerable<TableOfDimension> GetAll()
        {
            return db.TableOfDimensions;
        }

        public void Update(TableOfDimension tableOfDimension)
        {
            db.Entry(tableOfDimension).State = EntityState.Modified;
        }
    }
}
