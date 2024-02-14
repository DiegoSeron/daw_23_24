using System.ComponentModel.DataAnnotations;

namespace PizzaExample.Models;

public class PizzaDto
{
    public int PizzaId { get; set; }
    public string Nombre { get; set; }
    public List<IngredienteDto> Ingredientes { get; set; }
}