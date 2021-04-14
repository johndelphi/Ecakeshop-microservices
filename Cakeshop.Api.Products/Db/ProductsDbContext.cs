﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cakeshop.Api.Products.Db
{
    public class ProductsDbContext:DbContext
    {
        public DbSet<Product> products { get; set; }

    }
}
