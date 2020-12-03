using KafeinExample.CORE.Models;
using KafeinExample.CORE.Services;
using KafeinExample.DATA;
using KafeinExample.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KafeinExample.BUS
{
    public class ProductService : Repository<Products>, IProduct
    {
        public ProductService(KafeinDbContext context) : base(context) { }

    }
}
