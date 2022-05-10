using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PizzaServer.Models;

namespace PizzaServer.Tests;

public class BaseModelTest
{
    public DbContextOptions<ApplicationDbContext> getDbContextOptions()
    {
        var connection = new SqliteConnection();
        connection.ConnectionString = "DataSource=:memory:";
        connection.Open();

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>(); 
        optionsBuilder.UseSqlite(connection);

        return optionsBuilder.Options;
    }
    public ApplicationDbContext getContext()
    {

        var context = new ApplicationDbContext(getDbContextOptions());
        context.Database.Migrate();
        return context;
    }
}