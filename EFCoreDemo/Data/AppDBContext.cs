using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFCoreDemo.Data
{
    internal class AppDBContext:DbContext
    {
        //Mapping Classes to db Tables
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configurations = new ConfigurationManager()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            //const string connectionString = "Server=.; Database=EFCoreDemo; Integrated Security=True; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(configurations.GetConnectionString("Default"));
        }

    }
}
