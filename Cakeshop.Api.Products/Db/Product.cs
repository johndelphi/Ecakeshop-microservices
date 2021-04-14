using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cakeshop.Api.Products.Db
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal String { get; set; }
        public int inventory { get; set; }
    }
}
