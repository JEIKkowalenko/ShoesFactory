using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.WEB.Models
{
    public class MaterialViewModel
    {
        public MaterialViewModel()
        {
        }

        public MaterialViewModel(string name, string summary)
        {
            Name = name;
            Summary = summary;
        }

        public MaterialViewModel(int id, string name, string summary)
        {
            Id = id;
            Name = name;
            Summary = summary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public int Count { get; set; }
    }
}
