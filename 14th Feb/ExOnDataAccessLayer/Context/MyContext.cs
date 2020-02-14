using System;
using System.Collections.Generic;
using System.Text;
using ExOnDataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace ExOnDataAccessLayer.Context
{
    public class MyContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1BBLEIH\SQLEXPRESS;Initial Catalog=ItemDB;User ID=sa;Password=pass@word1");

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders{ get; set; }
    }
}
