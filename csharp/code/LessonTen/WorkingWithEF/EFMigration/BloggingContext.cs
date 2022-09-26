using Microsoft.EntityFrameworkCore;

namespace EFMigration;

public class BloggingContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Data Source=LUNATPC\\MSSQLDEV;" +
                                  "Initial Catalog=Blog;" +
                                  "Integrated Security=true";

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //exclude this entity from migration to avoid conflicts
        //modelBuilder.Entity<IdentityUser>()
        //    .ToTable("AspNetUsers"
        //        , t => t.ExcludeFromMigrations());

        modelBuilder.Entity<Blog>().ToTable("Blog");
        modelBuilder.Entity<Post>().ToTable("Post");
    }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
}