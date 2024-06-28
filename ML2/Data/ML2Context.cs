using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ML2.Model;

namespace ML2.Data
{
    public class ML2Context : DbContext
    {
        public ML2Context (DbContextOptions<ML2Context> options)
            : base(options)
        {
        }

        public DbSet<ML2.Model.Customer> Customer { get; set; } = default!;
    }
}
