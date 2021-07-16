using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sprout.Exam.Business.DataTransferObjects
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Birthdate { get; set; }
        public string Tin { get; set; }
        [Column("EmployeeTypeId")]
        public int TypeId { get; set; }

        public bool isDeleted { get; set; }
    }

    public class EmployeeContext : DbContext
    {

        IDatabaseManager _dbm;
        public EmployeeContext(IDatabaseManager dbm)
        {
            _dbm = dbm;
        }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbm.GetConnectionString("EmployeeDBConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Birthdate)
                      .HasConversion<DateTime>();


                entity.Property(e => e.isDeleted)
                      .HasConversion<Boolean>();
            });


        }
    }
}
