using GoSeed.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoSeed.Backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<SoftPlan> SoftPlans => Set<SoftPlan>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Condiciones para los modelos, como aplicaciones de Index
        modelBuilder.Entity<SoftPlan>().HasIndex(x => x.Name).IsUnique();
        modelBuilder.Entity<SoftPlan>().Property(x => x.Name).HasPrecision(18, 2);
    }
}