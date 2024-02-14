using PizzaExample.Models;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace PizzaExample.Data
{

    public class PizzaEFRepository : IPizzaRepository
    {


        private readonly PizzaContext _context;

        public PizzaEFRepository(PizzaContext context)
        {

            _context = context;
        }

        public List<Pizza> GetAll()
        {
            var pizzas = _context.Pizzas
                .Include(p => p.PizzaIngredientes)
                .ThenInclude(pi => pi.Ingrediente)
                .ToList();

            var pizzasDto = pizzas.Select(p => new PizzaDto
            {
                PizzaId = p.PizzaId,
                Nombre = p.Nombre,
                Ingredientes = p.PizzaIngredientes.Select(pi => new IngredienteDto
                {
                    IngredienteId = pi.Ingrediente.IngredienteId,
                    Nombre = pi.Ingrediente.Nombre
                }).ToList()
            }).ToList();

            return pizzasDto;
        }

        public void Add(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            SaveChanges();
        }

        public Pizza Get(int id)
        {
            return _context.Pizzas.FirstOrDefault(pizza => pizza.Id == id);
        }

        public void Update(Pizza pizza)
        {
            _context.Entry(pizza).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int id)
        {
            var pizza = Get(id);
            if (pizza is null)
            {
                throw new KeyNotFoundException("Pizza not found.");
            }
            _context.Pizzas.Remove(pizza);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}