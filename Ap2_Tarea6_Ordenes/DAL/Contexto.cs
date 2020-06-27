using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ap2_Tarea6_Ordenes.Models;

namespace Ap2_Tarea6_Ordenes.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Ordenes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId = 1,
                Nombres = "Nestle"
            });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId = 2,
                Nombres = "SuperCentro"
            });

            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 1,
                Descripcion = "Cereal",
                Costo = 70,
                Inventario = 6
            });
            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 2,
                Descripcion = "Coca-Cola",
                Costo = 25,
                Inventario = 20
            });
            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 3,
                Descripcion = "Pizza",
                Costo = 50,
                Inventario = 10
            });
            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 4,
                Descripcion = "Pastel",
                Costo = 100,
                Inventario = 4
            });
        }
    }
}
