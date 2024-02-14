using System.ComponentModel.DataAnnotations;

namespace PizzaExample.Models;

public class IngredienteDto
{
    public int IngredienteId { get; set; }
    public string Nombre { get; set; }
}