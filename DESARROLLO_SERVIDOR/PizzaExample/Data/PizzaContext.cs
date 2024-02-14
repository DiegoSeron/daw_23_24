using Microsoft.EntityFrameworkCore;
using PizzaExample.Models;
using Microsoft.Extensions.Configuration;

namespace PizzaExample.Data
{
    public class PizzaContext : DbContext
    {

        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {

        }

      protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza { Id = 1, Name = "Peperoni", IsGlutenFree = false},
                new Pizza { Id = 2, Name = "Jamon y queso", IsGlutenFree = false}
            );
            modelBuilder.Entity<Ingrediente>().HasData(
                new Ingrediente { Id = 1, Name = "Peperoni", Origen="Animal", PizzaId = 1, Calorias = 34},
                new Ingrediente { Id = 2, Name = "Queso", Origen="Animal", PizzaId = 2, Calorias = 56},
                new Ingrediente { Id = 3, Name = "Jamon", Origen="Animal", PizzaId = 2, Calorias = 27},
                new Ingrediente { Id = 4, Name = "Oregano", Origen="Vegetal", PizzaId = 1, Calorias = 4}
            );
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingrediente> Ingredients { get; set; }
       
    }
}
