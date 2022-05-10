using System.Linq;
using AutoBogus;
using PizzaServer.Models.Models;
using Xunit;

namespace PizzaServer.Tests;

public class ToppingTest : BaseModelTest
{
    [Fact]
    public void ItExists()
    {
        Topping topping = new Topping();
    }
    
    [Fact]
    public void ItSavesToDatabase()
    {
        using var context = getContext();
        var topping = new AutoFaker<Topping>().Generate();
        
        context.Toppings.Add(topping);
        context.SaveChanges();

        var result = context.Toppings.First();
        
        Assert.Equal(result.Id, topping.Id);
    }
    
    [Fact]
    public void ItSavesANameToDatabase()
    {
        using var context = getContext();
        var topping = new AutoFaker<Topping>().Generate();


        context.Toppings.Add(topping);
        context.SaveChanges();

        var result = context.Toppings.First();

        Assert.Equal(result.Name, topping.Name);
    }


}