using LiveEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveEFCore.Persistence
{
    public class LiveEFCoreDbContext : DbContext
    {
        public LiveEFCoreDbContext(DbContextOptions<LiveEFCoreDbContext> options) : base(options)
        {

        }

        public DbSet<School> Schools {get;set;}
        public DbSet<Student> Students {get;set;}
        public DbSet<ContactInformation> ContactInformations {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API em caso de utilizar muitos atributos
            modelBuilder.Entity<School>()
                .ToTable("School");

            modelBuilder.Entity<School>()
                .HasKey(s=>s.Id);
            
            modelBuilder.Entity<Student>()
                .HasKey(s=>s.Id);
            
            modelBuilder.Entity<ContactInformation>()
                .HasKey(s=>s.Id);
            // Parametros sempre cadastrados
            modelBuilder.Entity<School>()
                .HasData( new School(1, "School cool"), new School(2, "School Bad"));

            modelBuilder.Entity<School>()
                .Property(s => s.Name)
                .HasMaxLength(100)
                .HasDefaultValue("Nome padrao")
                .HasColumnName("Name");

            //Definir valor padrao usando sql
            //modelBuilder.Entity<School>()
            //    .HasKey(s => s.Id);
            //modelBuilder.Entity<School>()
            //    .Property(s => s.Id)
            //    .HasDefaultValueSql("NEWID()");
            //Guid.NewGuid()

            //1:N
            modelBuilder.Entity<School>()
                .HasMany(s => s.Student)
                .WithOne(s => s.School)
                .HasForeignKey(s=>s.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
            // To exclude some data In cascade In Logic Delete

            //1:1
            modelBuilder.Entity<School>()
                .HasOne(s => s.ContactInformation)
                .WithOne()
                .HasForeignKey<ContactInformation>(s => s.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
