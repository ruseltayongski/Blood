using Blood.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blood.Data
{
    public class BloodTypeDbContext : DbContext
    {
        public BloodTypeDbContext(DbContextOptions<BloodTypeDbContext> options)
            : base(options)
        {
        }

        public DbSet<BloodType> blood_type { get; set; }
    }
}
