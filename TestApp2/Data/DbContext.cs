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
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<Project>()
        //            .Property(b => b.ProjectStatus)
        //            .HasConversion(x => (int)x, x => (ProjectStatus)x);

        //        modelBuilder.Entity<Task>()
        //            .Property(b => b.TaskStatus)
        //            .HasConversion(x => (int)x, x => (TaskStatus)x);

        //}

    }
    
}
