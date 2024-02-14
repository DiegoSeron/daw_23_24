
using PizzaExample.Models;
using PizzaExample.Data;


namespace PizzaExample.Business
{
    public class PizzaService : IPizzaService
    {

        private readonly IPizzaRepository _pizzaRepository;
        

        public PizzaService(IPizzaRepository pizzaRepository){
            _pizzaRepository = pizzaRepository;
        
        }
        public  List<Pizza> GetAll()
        {
            var pizzas = _pizzaRepository.GetAll();
            // foreach (var pizza in pizzas)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }
            return pizzas;
        }

        public  Pizza Get(int id)
        {
            var pizza = _pizzaRepository.Get(id);

            // if (pizza != null)
            // {
            //     pizza.Ingredientes = _ingredientesRepository.GetIngredientesByPizzaId(pizza.Id);
            // }

            return pizza;
        }
          

    public  void Add(Pizza pizza)
    {
        _pizzaRepository.Add(pizza);

            // foreach (var ingrediente in pizza.Ingredientes)
            // {
            //     _ingredientesRepository.AddIngredienteToPizza(ingrediente, pizza.Id);
            // }
    }

    public  void Update(Pizza pizza)
    {
        _pizzaRepository.Update(pizza);

            // _ingredientesRepository.UpdateIngredientesForPizza(pizza.Ingredientes, pizza.Id);
    }

    public  void Delete(int id)
    {
        _pizzaRepository.Delete(id);
    }
}


        
    }

