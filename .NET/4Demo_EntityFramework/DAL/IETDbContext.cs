using _45Demo_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace _45Demo_EntityFramework.DAL
{
    public class IETDbContext : DbContext

    {

        public DbSet<Emp1>emps {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("conStr"));
        }
    }
}
