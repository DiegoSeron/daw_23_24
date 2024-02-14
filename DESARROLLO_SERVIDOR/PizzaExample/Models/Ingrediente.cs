namespace PizzaExample.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
public class Ingrediente
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Origen { get; set; }

    [ForeignKey("Pizza")]
    public int PizzaId { get; set; }
    [Required]
    public int? Calorias { get; set; }

    public static int ingredienteSeed = 1;

    public Ingrediente(){}

    public Ingrediente(string name, string origen, int pizzaId, int calorias){
        Name = name;
        Origen = origen;
        Id = ingredienteSeed;
        PizzaId = pizzaId;
        Calorias = calorias;
        ingredienteSeed++;
    }
}