using PizzaExample.Models;

namespace PizzaExample.Business
{
    public interface IPizzaService
    {
         List<Pizza> GetAll();
        // GetAll(int id);
        void Add(Pizza pizza);
        Pizza Get(int id);
        void Update(Pizza pizza);
        void Delete (int id);


    }
}