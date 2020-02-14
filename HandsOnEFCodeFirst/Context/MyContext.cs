using System;
using System.Collections.Generic;
using System.Text;
using HandsOnEFCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirst.Context
{
    class MyContext:DbContext
    {
        //Define Entities
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Define Connection String
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1BBLEIH\SQLEXPRESS;Initial Catalog=StudentDB;User ID=sa;Password=pass@word1");
        }
    }
}
