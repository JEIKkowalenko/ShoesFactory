using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class Size
    {
        public Size()
        {
            TablesOfDimensions = new List<TableOfDimension>();
        }

        public Size(double uS, double uK, double eU, string sex)
        {
            US = uS;
            UK = uK;
            EU = eU;
            Sex = sex;
            TablesOfDimensions = new List<TableOfDimension>();
        }

        public int Id { get; set; }
        public double US { get; set; }
        public double UK { get; set; }
        public double EU { get; set; }
        public string Sex { get; set; }
        public ICollection<TableOfDimension> TablesOfDimensions { get; set; }

    }
}
