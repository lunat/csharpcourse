using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Shared;

public static class NorthwindContextExtensions
{
    public static IServiceCollection AddNorthwindContext(
        this IServiceCollection services, string connectionString = "")
    {
        string cs = string.IsNullOrEmpty(connectionString)
            ? "Data Source = LUNATPC\\MSSQLDEV;Initial Catalog = Northwind;Integrated Security=true;\""
            : connectionString;

        services.AddDbContext<NorthwindContext>(options =>
            options.UseSqlServer(cs));

        return services;
    }
}