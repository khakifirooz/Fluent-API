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
       // modelBuilder.Entity<Employee>().HasKey(e => e.Id);  // choosing primarykey
        modelBuilder.Entity<Employee>().HasKey(x => new { x.Name, x.Family });  // mixed primarykey
                                                                                //  modelBuilder.Ignore<Employee>(); // not mapping

        //properties:
        modelBuilder.Entity<Employee>()  // .Ignore();   for not mapping this property
            .Property(x => x.Name)
            .HasColumnName("FirstName")
            .HasColumnType("nvarchar(50)")
            .HasColumnOrder(0)
            .IsRequired(true);

        modelBuilder.Entity<Employee>()
            .Property(x => x.Family)
            .HasColumnOrder(1)
            .HasMaxLength(100)
            .IsRequired(false);

        modelBuilder.Entity<Employee>()
            .Property(x => x.Id)
            .HasColumnOrder(2);
    }
}
