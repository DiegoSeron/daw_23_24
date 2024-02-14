using PizzaExample.Models;

namespace PizzaExample.Business
{
    public interface IIngredienteService
    {
         List<Ingrediente> GetAll();
        // GetAll(int id);
        void Add(Ingrediente ingrediente);
        Ingrediente Get(int id);
        void Update(Ingrediente ingrediente);
        void Delete (int id);


    }
}