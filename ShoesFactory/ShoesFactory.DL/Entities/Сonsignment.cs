using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class Сonsignment
    {
        public Сonsignment()
        {

        }
        public Сonsignment(Shoes shoes,  Employer employer, double price)
        {
            Date = DateTime.Now;
            Shoes = shoes;
            Employer = employer;
            Price = price;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int? ShoesId { get; set; }
        public virtual Shoes Shoes { get; set; }
        public int? EmployerId { get; set; }
        public virtual Employer Employer { get; set; }
    }
}
