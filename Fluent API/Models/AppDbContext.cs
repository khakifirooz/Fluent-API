using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Fluent_API.Models;

public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configBulder = new ConfigurationBuilder();
        var configuration = configBulder.AddJsonFile("appsettings.json").Build();
        var configSection = configuration.GetSection("ConnectionStrings");
        var connectionString = configSection["DBConnection"];
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("HR");
    }
}
