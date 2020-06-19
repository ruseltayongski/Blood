using Blood.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blood.Data
{
    public class ComponentDbContext : DbContext
    {
        public ComponentDbContext(DbContextOptions<ComponentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Component> component { get; set; }

    }
}
