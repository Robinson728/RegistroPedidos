using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroPedidos.Models;

namespace RegistroPedidos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\PedidosDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Suplidores>().HasData(
                    new Suplidores() { SuplidorId = 1, Nombres = "Ernesto Juan" },
                    new Suplidores() { SuplidorId = 2, Nombres = "Kamila Santos" },
                    new Suplidores() { SuplidorId = 3, Nombres = "Enel Brito" },
                    new Suplidores() { SuplidorId = 4, Nombres = "Robinson Manuel" },
                    new Suplidores() { SuplidorId = 5, Nombres = "Candy Sarante" }
                );

            modelBuilder.Entity<Productos>().HasData(
                    new Productos() { ProductoId = 1, Descripcion = "Pan", Costo = 10, Inventario = 15 },
                    new Productos() { ProductoId = 2, Descripcion = "Café", Costo = 150, Inventario = 10 },
                    new Productos() { ProductoId = 3, Descripcion = "Cremola", Costo = 210, Inventario = 5 },
                    new Productos() { ProductoId = 4, Descripcion = "Azúcar", Costo = 20, Inventario = 17 },
                    new Productos() { ProductoId = 5, Descripcion = "Chupeta", Costo = 5, Inventario = 25 }
                );
        }
    }
}
