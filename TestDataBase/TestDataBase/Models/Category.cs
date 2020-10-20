using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDataBase.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Thoisu> Thoisus { get; set; }
        public List<Thegioi> Thegiois { get; set; }
        public List<Thethao> Thethaos { get; set; }
        public List<Suckhoe> Suckhoes { get; set; }
        public List<Dulich> Duliches { get; set; }
    }
}
