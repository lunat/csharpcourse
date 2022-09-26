using Microsoft.EntityFrameworkCore;

namespace Shared;

public class Northwind : DbContext
{
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();

        if (ProjectConstants.DataBaseProvider == "SQLServer")
        {
            string connection = "Data Source = LUNATPC\\MSSQLDEV;" +
                                "Initial Catalog = Northwind;" +
                                "Integrated Security=true;" +
                                "MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connection);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .Property(c => c.CategoryName)
            .IsRequired()
            .HasMaxLength(15);

        modelBuilder.Entity<Product>()
            .HasQueryFilter(p => !p.Discontinued);

        if (ProjectConstants.DataBaseProvider == "SqlLite")
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Cost)
                .HasConversion<double>();
        }
    }
}
