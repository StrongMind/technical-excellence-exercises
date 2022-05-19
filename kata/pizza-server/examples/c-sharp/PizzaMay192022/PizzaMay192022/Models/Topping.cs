namespace PizzaMay192022.Models;

public class Topping
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Pizza> Pizzas { get; set; }
}