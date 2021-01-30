using DevBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBook.Domain.Repositories
{
    public class DataContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=DevBook;Integrated Security=true",
                o => o.EnableRetryOnFailure(maxRetryCount: 5));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                //u.ToTable("Users");
                u.HasKey(u => u.Id);
                u.Property(u => u.FirstName).HasColumnType("VARCHAR(40)").IsRequired();
                u.Property(u => u.LastName).HasColumnType("VARCHAR(40)").IsRequired();
                u.Property(u => u.EmailAddress).HasColumnType("VARCHAR(40)").IsRequired();
                u.Property(u => u.PhoneNumber).HasColumnType("VARCHAR(14)").IsRequired();
                u.Property(u => u.DateOfBirth).HasColumnType("CHAR(8)").IsRequired();

            });


            modelBuilder.Entity<Address>(a =>
            {
                //u.ToTable("Address");
                a.HasKey(u => u.Id);
                a.Property(u => u.City).HasColumnType("VARCHAR(40)").IsRequired();
                a.Property(u => u.Country).HasColumnType("VARCHAR(40)").IsRequired();
                a.Property(u => u.Neighborhood).HasColumnType("VARCHAR(40)").IsRequired();
                a.Property(u => u.Number).HasColumnType("VARCHAR(40)").IsRequired();
                a.Property(u => u.State).HasColumnType("VARCHAR(40)").IsRequired();
                a.Property(u => u.Street).HasColumnType("VARCHAR(40)").IsRequired();
                a.Property(u => u.ZipCode).HasColumnType("VARCHAR(40)").IsRequired();
            });

            modelBuilder.Entity<Formation>(a =>
            {
                //a.ToTable("Accounts");
                a.HasKey(a => a.Id);
                a.Property(a => a.Name).HasColumnType("VARCHAR(40)");
                a.Property(a => a.Type).HasConversion<string>();
            });

            modelBuilder.Entity<Account>(a =>
            {
                //a.ToTable("Accounts");
                a.HasKey(a => a.Id);
                a.Property(a => a.EmailOrCPF).HasConversion<string>().IsRequired();
                a.Property(a => a.Password).HasColumnType("VARCHAR(12)").IsRequired();
            });

            modelBuilder.Entity<Company>(u =>
            {
                //u.ToTable("Professions");
                u.HasKey(u => u.Id);
                u.Property(u => u.Name).HasColumnType("VARCHAR(40)");
                u.Property(u => u.EndDate);
                u.Property(u => u.StartDate);
            });


            modelBuilder.Entity<Profession>(u =>
            {
                //u.ToTable("Professions");
                u.HasKey(u => u.Id);
                u.Property(u => u.Name).HasColumnType("VARCHAR(40)");
                u.Property(u => u.EndDate);
                u.Property(u => u.StartDate);
            });

            modelBuilder.Entity<Role>(u =>
            {
                //u.ToTable("Professions");
                u.HasKey(u => u.Id);
                u.Property(u => u.Name).HasColumnType("VARCHAR(40)");
                u.Property(u => u.EndDate);
                u.Property(u => u.StartDate);
                u.Property(u => u.Salary).HasColumnType("DECIMAL(10,2)");
            });


        }
    }
}
