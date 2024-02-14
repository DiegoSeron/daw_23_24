using PizzaExample.Models;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace PizzaExample.Data
{

    public class IngredienteEFRepository : IIngredientesRepository
    {


        private readonly PizzaContext _context;

        public IngredienteEFRepository(PizzaContext context)
        {

            _context = context;
        }

        public List<Ingrediente> GetAll()
        {
             return _context.Ingredients.ToList();
        }

        public void Add(Ingrediente ingrediente)
        {
            _context.Ingredients.Add(ingrediente);
            SaveChanges();
        }

        public Ingrediente Get(int id)
        {
            return _context.Ingredients.FirstOrDefault(i => i.Id == id);
        }

        public void Update(Ingrediente ingrediente)
        {
            _context.Entry(ingrediente).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int id)
        {
            var ingrediente = Get(id);
            if (ingrediente is null) {
                throw new KeyNotFoundException("Ingredient not found.");
            }
            _context.Ingredients.Remove(ingrediente);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}