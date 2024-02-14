using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaExample.Models;

public class PizzaIngrediente
{
    [ForeignKey("Pizza")]
    public int PizzaId { get; set; }
    [Required]
    public Pizza Pizza { get; set; }
    [Required]

    [ForeignKey("Ingrediente")]
    public int IngredienteId {get; set;}
    [Required]
    public Ingrediente Ingrediente {get; set;}

    public PizzaIngrediente(){}

    public PizzaIngrediente(Pizza pizza, Ingrediente ingrediente){
        Ingrediente = ingrediente;
        Pizza = pizza;
    }
}