using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestApp2.Data
{
        public class TestContext : DbContext
        {
            //required to retrive conection string
            private readonly IConfiguration? _configuration;
            public DbSet<Data.Project>? Projects { get; set; }
            public DbSet<Data.Task>? Tasks { get; set; }
            public TestContext(DbContextOptions<TestContext> options, IConfiguration? configuration)
                : base(options)
            {
                _configuration = configuration;
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("TestContext"));
            }

    }
    
}
