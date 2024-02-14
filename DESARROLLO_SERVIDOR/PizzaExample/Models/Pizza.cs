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
    public List<PizzaIngrediente> PizzaIngredientes { get; set; }
    public static int pizzaSeed = 1;

    public Pizza(){}

    public Pizza(string name, bool isGlutenFree){
        Name = name;
        Id = pizzaSeed;
        IsGlutenFree = isGlutenFree;
        pizzaSeed++;
    }
}