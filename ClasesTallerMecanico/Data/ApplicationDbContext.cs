using ClasesTallerMecanico.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<Maquina> Maquinas { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=MSI;Database=TallerMecanicoProgramacion;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración para TPT (Table Per Type) en la jerarquía Persona
            // Esto asegura que cada clase tenga su propia tabla en la DB.
            modelBuilder.Entity<Persona>().ToTable("Persona");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Proveedor>().ToTable("Proveedor");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");

            // Opcional: Configuración explícita de relaciones y constraints (buenas prácticas)

            // Relación 1:N entre Localidad y Persona
            modelBuilder.Entity<Persona>()
                .HasOne(p => p.Localidad) // Persona tiene una Localidad
                .WithMany(l => l.Personas) // Localidad tiene muchas Personas
                .HasForeignKey(p => p.IdLocalidad) // La FK es IdLocalidad
                .IsRequired(); // Ya que IdLocalidad es Not Null

            // Relación 1:N entre Rol y Usuario
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany(r => r.Usuarios)
                .HasForeignKey(u => u.IdRol)
                .IsRequired();

            // Relación N:1 entre Insumo y Proveedor
            modelBuilder.Entity<Insumo>()
                .HasOne(i => i.Proveedor)
                .WithMany(p => p.Insumos)
                .HasForeignKey(i => i.IdProveedor)
                .IsRequired();

            // Relación N:1 entre Maquina y Cliente
            modelBuilder.Entity<Maquina>()
                .HasOne(m => m.Cliente)
                .WithMany(c => c.Maquinas)
                .HasForeignKey(m => m.IdCliente)
                .IsRequired();

            // Relaciones N:1 en Turno
            modelBuilder.Entity<Turno>()
                .HasOne(t => t.Cliente)
                .WithMany(c => c.Turnos)
                .HasForeignKey(t => t.IdCliente)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict); // Evita eliminación en cascada de Clientes

            modelBuilder.Entity<Turno>()
                .HasOne(t => t.Maquina)
                .WithMany() // No es necesario que Maquina tenga una colección de Turnos si no se usa
                .HasForeignKey(t => t.IdMaquina)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
