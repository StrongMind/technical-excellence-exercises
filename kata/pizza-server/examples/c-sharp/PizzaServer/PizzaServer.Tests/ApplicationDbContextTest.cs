using System;
using Microsoft.EntityFrameworkCore;
using PizzaServer.Models;
using PizzaServer.Models.Models;
using Xunit;

namespace PizzaServer.Tests;

public class ApplicationDbContextTest : BaseModelTest
{
    [Fact]
    public void ItExists()
    {
        var context = new ApplicationDbContext(getDbContextOptions());
        Assert.NotNull(context);
    }

    [Fact]
    public void ItIsDisposable()
    {
        var context = new ApplicationDbContext(getDbContextOptions());
        Assert.True(context is IDisposable);
    }

    [Fact]
    public void ItIsADbContext()
    {
        var context = new ApplicationDbContext(getDbContextOptions());
        Assert.True(context is DbContext);
    }

    [Fact]
    public void ItHasPizzas()
    {
        var context = new ApplicationDbContext(getDbContextOptions());
        Assert.True(context.Pizzas is DbSet<Pizza>);
    }
    
    [Fact]
    public void ItHasToppings()
    {
        var context = new ApplicationDbContext(getDbContextOptions());
        Assert.True(context.Toppings is DbSet<Topping>);
    }
}