using Blood.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blood.Data
{
    public class TestDbContext1 : DbContext
    {
        public TestDbContext1(DbContextOptions<TestDbContext1> options)
            : base(options)
        {
        }

        public DbSet<Test1> test_table1 { get; set; }
    }
}
