using System.ComponentModel.DataAnnotations;

namespace PizzaExample.Models;

public class Pizza
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public bool IsGlutenFree { get; set; }
    [Required]
    public List<Ingrediente>? Ingredientes { get; set; }
}