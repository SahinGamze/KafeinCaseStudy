using KafeinExample.CORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KafeinExample.DATA
{
    public class KafeinDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }

        public KafeinDbContext(DbContextOptions<KafeinDbContext> options)
            : base(options)
        { }
    
    }
}
