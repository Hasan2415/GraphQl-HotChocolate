using Microsoft.EntityFrameworkCore;

namespace DataLayer;

public class EfDataContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=GraphQlSample;Trusted_Connection=True;TrustServerCertificate=true");
    }
}