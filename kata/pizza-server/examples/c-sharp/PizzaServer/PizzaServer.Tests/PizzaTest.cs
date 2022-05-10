using System.Linq;
using AutoBogus;
using Bogus;
using PizzaServer.Models;
using PizzaServer.Models.Models;
using Xunit;

namespace PizzaServer.Tests;

public class PizzaTest : BaseModelTest
{
    [Fact]
    public void ItExists()
    {
        Pizza pizza = new Pizza();
    }

    [Fact]
    public void ItSavesToDatabase()
    {
        using var context = getContext();
        var pizza = new AutoFaker<Pizza>().Generate();
        
        context.Pizzas.Add(pizza);
        context.SaveChanges();

        var result = context.Pizzas.First();
        
        Assert.Equal(result.Id, pizza.Id);
    }

    [Fact]
    public void ItSavesANameToDatabase()
    {
        using var context = getContext();
        var pizza = new AutoFaker<Pizza>().Generate();


        context.Pizzas.Add(pizza);
        context.SaveChanges();

        var result = context.Pizzas.First();

        Assert.Equal(result.Name, pizza.Name);
    }
}