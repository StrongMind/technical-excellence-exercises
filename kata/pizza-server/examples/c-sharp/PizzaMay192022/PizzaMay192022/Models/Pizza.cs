namespace PizzaMay192022.Models;

public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Topping> Toppings { get; set; }
}