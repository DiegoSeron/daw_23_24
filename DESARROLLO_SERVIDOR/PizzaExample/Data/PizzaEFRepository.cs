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
            List<Pizza> pizzas = new List<Pizza>();

            // using (var connection = new SqlConnection(_connectionString))
            // {

            //     connection.Open();

            //     var sqlString = "SELECT idPizza, name, isGlutenFree FROM PIZZA";
            //     var command = new SqlCommand(sqlString, connection);

            //     using (var reader = command.ExecuteReader())
            //     {
            //         while (reader.Read())
            //         {
            //             var pizza = new Pizza
            //             {
            //                 Id = Convert.ToInt32(reader["idPizza"]),
            //                 Name = reader["name"].ToString(),
            //                 IsGlutenFree = Convert.ToBoolean(reader["isGlutenFree"])
            //             };
            //             pizzas.Add(pizza);
            //         }
            //     }
            // }

            
             return pizzas;
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
            if (pizza is null) {
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