﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesFactory.DAL.Entities
{
    public class Material
    {
        public Material()
        {
        }

        public Material(string name, string summary, int count)
        {
            Name = name;
            Summary = summary;
            Count = count;
            Supplies = new List<Supply>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public int Count { get; set; }
        public ICollection<Supply> Supplies { get; set; }

    }
}
