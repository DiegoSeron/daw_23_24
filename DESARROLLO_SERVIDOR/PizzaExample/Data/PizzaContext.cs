using Microsoft.EntityFrameworkCore;
using PizzaExample.Models;
using Microsoft.Extensions.Configuration;
using PizzaExample.Data.Migrations;

namespace PizzaExample.Data
{
    public class PizzaContext : DbContext
    {

        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaIngrediente>()
                .HasKey(pi => new { pi.PizzaId, pi.IngredienteId });

            modelBuilder.Entity<PizzaIngrediente>()
                .HasOne(pi => pi.Pizza)
                .WithMany(p => p.PizzaIngredientes)
                .HasForeignKey(pi => pi.PizzaId);

            modelBuilder.Entity<PizzaIngrediente>()
                .HasOne(pi => pi.Ingrediente)
                .WithMany(i => i.PizzaIngredientes)
                .HasForeignKey(pi => pi.IngredienteId);

            modelBuilder.Entity<Pizza>().HasData(
                new Pizza { Id = 1, Name = "Peperoni", IsGlutenFree = false },
                new Pizza { Id = 2, Name = "Jamon y queso", IsGlutenFree = false }
            );
            modelBuilder.Entity<Ingrediente>().HasData(
                new Ingrediente { Id = 1, Name = "Peperoni", Origen = "Animal", Calorias = 34 },
                new Ingrediente { Id = 2, Name = "Queso", Origen = "Animal", Calorias = 56 },
                new Ingrediente { Id = 3, Name = "Jamon", Origen = "Animal", Calorias = 27 },
                new Ingrediente { Id = 4, Name = "Oregano", Origen = "Vegetal", Calorias = 4 }
            );
            modelBuilder.Entity<PizzaIngrediente>().HasData(
                new PizzaIngrediente { PizzaId = 1, IngredienteId = 1},
                new PizzaIngrediente { PizzaId = 1, IngredienteId = 2},
                new PizzaIngrediente { PizzaId = 2, IngredienteId = 3},
                new PizzaIngrediente { PizzaId = 2, IngredienteId = 1},
                new PizzaIngrediente { PizzaId = 1, IngredienteId = 4}
            );
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingrediente> Ingredients { get; set; }
        public DbSet<PizzaIngrediente> PizzaIngredients { get; set; }

    }
}
