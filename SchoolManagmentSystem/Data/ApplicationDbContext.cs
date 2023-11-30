using Microsoft.EntityFrameworkCore;
using SchoolManagmentSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
      public DbSet<Student> Students { get; set; }
      public DbSet<Teacher> Teachers { get; set; }
      public DbSet<ClassRoom> Classrooms { get; set; }
      public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.; Database=SchoolMangmentDb; Integrated Security=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Teacher>()
            //    .ToTable("tbl_Teachers")
            //    .HasKey(t => t.Id);
        }
    }
}
