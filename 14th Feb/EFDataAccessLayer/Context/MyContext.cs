using System;
using System.Collections.Generic;
using System.Text;
using EFDataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDataAccessLayer.Context
{
    public class MyContext : DbContext
    {
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1BBLEIH\SQLEXPRESS;Initial Catalog=EmplDB;User ID=sa;Password=pass@word1");

        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

