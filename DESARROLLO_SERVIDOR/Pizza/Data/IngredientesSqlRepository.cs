using PizzaExample.Models;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;

namespace PizzaExample.Data
{

    public class IngredienteSqlRepository : IIngredientesRepository
    {

        private readonly string _connectionString;

        private  int nextId;
        public IngredienteSqlRepository(string connectionString)
        {

            _connectionString = connectionString;
        }

        public  List<Ingrediente> GetAll()
        {
           List<Ingrediente> ingredientes  = new List<Ingrediente>();

            using (var connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                var sqlString = "SELECT idPizza, name, isGlutenFree FROM PIZZA";
                var command = new SqlCommand(sqlString, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ingrediente = new Ingrediente
                        {
                            Id = Convert.ToInt32(reader["idPizza"]),
                            Name = reader["name"].ToString(),
                            IsGlutenFree = Convert.ToBoolean(reader["isGlutenFree"])
                        };
                    ingredientes.Add(ingrediente);
                    } 
                }
            }

            return pizzas;
        }

        public void Add(Pizza pizza)
        {
            using (var connection = new SqlConnection(_connectionString))
    {
        connection.Open();

        var sqlString = "INSERT INTO PIZZA (name, isGlutenFree) VALUES('@Name', @IsGlutenFree)";
        var command = new SqlCommand(sqlString, connection);

        // Utilizamos parámetros para evitar la inyección de SQL
        command.Parameters.AddWithValue("@Name", pizza.Name);
        command.Parameters.AddWithValue("@IsGlutenFree", pizza.IsGlutenFree);

    }
        }

        public Pizza Get(int id)
        {
            var pizza = new Pizza();

            using (var connection = new SqlConnection(_connectionString))
            {

                connection.Open();

                var sqlString = "SELECT idPizza, Name, IsGlutenFree FROM PIZZA WHERE idPizza=" + id;
                var command = new SqlCommand(sqlString, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pizza = new Pizza
                        {
                            Id = Convert.ToInt32(reader["idPizza"]),
                            Name = reader["name"].ToString(),
                            IsGlutenFree = Convert.ToBoolean(reader["isGlutenFree"])
                        };
                    }
                }
            }

            return pizza;
        }

        public void Update(Pizza pizza)
{
    /* using (var connection = new SqlConnection(_connectionString))
    {
        connection.Open();

        var sqlString = "UPDATE PIZZA SET name=@Name, isGlutenFree=@IsGlutenFree WHERE idPizza=@Id";
        var command = new SqlCommand(sqlString, connection);

        // Utilizamos parámetros para evitar la inyección de SQL
        command.Parameters.AddWithValue("@Name", pizza.Name);
        command.Parameters.AddWithValue("@IsGlutenFree", pizza.IsGlutenFree);
        command.Parameters.AddWithValue("@Id", pizza.Id);

        // Ejecutamos la consulta de actualización
        int rowsAffected = command.ExecuteNonQuery();

        // Puedes verificar rowsAffected para ver cuántas filas fueron afectadas
        if (rowsAffected > 0)
        {
            Console.WriteLine("La pizza fue actualizada exitosamente.");
        }
        else
        {
            Console.WriteLine("No se pudo encontrar la pizza con el ID especificado.");
        }
    } */
}

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
    {
        connection.Open();

        var sqlString = "DELETE FROM PIZZA WHERE idPizza=" + id;
        var command = new SqlCommand(sqlString, connection);

        command.ExecuteNonQuery();
    }
        }
        public List<Ingrediente> GetIngredientesByPizzaId(int pizzaId)
        {
            // Puedes agregar lógica aquí para obtener los ingredientes asociados a una pizza específica
            // Devuelve una lista de ingredientes relacionados con la pizzaId
            return Ingredientes.Where(i => i.PizzaId == pizzaId).ToList();
        }

        public void AddIngredienteToPizza(Ingrediente ingrediente, int pizzaId)
        {
            // Puedes agregar lógica aquí para asociar un ingrediente a una pizza específica
            ingrediente.Id = nextId++;
            ingrediente.PizzaId = pizzaId;
            Ingredientes.Add(ingrediente);
        }

        public void UpdateIngredientesForPizza(List<Ingrediente> ingredientes, int pizzaId)
        {
            // Puedes agregar lógica aquí para actualizar la lista de ingredientes asociada a una pizza específica
            // Puedes borrar todos los ingredientes asociados a la pizza y luego agregar los nuevos
            Ingredientes.RemoveAll(i => i.PizzaId == pizzaId);
            foreach (var ingrediente in ingredientes)
            {
                AddIngredienteToPizza(ingrediente, pizzaId);
            }
        }



    }

}