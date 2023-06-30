using LABORATORIO14C.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LABORATORIO14C.DataContext
{
    public class AppDbContext : DbContext
    {
        string DbPath = string.Empty;


        //Tablas de base de datos
        public DbSet<Course> Course { get; set; }

        //Estándar del desarrollo con EFC
        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }
    }
}
