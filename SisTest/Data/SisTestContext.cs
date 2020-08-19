using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SisTest.Models
{
    public class SisTestContext : DbContext
    {
        public SisTestContext (DbContextOptions<SisTestContext> options)
            : base(options)
        {
        }

        public DbSet<SisTest.Models.Cliente> Cliente { get; set; }
    }
}
