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
        public Сonsignment(DateTime date, Shoes shoes,  Employer employer)
        {
            Date = DateTime.Now;
            Shoes = shoes;
            Employer = employer;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? ShoesId { get; set; }
        public Shoes Shoes { get; set; }
        public int? EmployerId { get; set; }
        public Employer Employer { get; set; }
    }
}
