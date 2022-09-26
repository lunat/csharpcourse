using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using Shared;
using static System.Console;

WriteLine($"Using {ProjectConstants.DataBaseProvider} database provider");
//QueryingCategories();
//FilteredIncludes();
//QueryingProducts();
//QueryWithLike();

//if (AddProduct(categoryId: 6,
//        productName: "Bob's Burgers",
//        price: 500M))
//{
//    WriteLine("Products added successfully");
//}

//if (IncreaseProductPrice("Bob", 20m))
//{
//    WriteLine("Product updated successfully");
//}

int deleted = DeleteProducts("Bob");
WriteLine($"{deleted} products were deleted");

ListProducts();

static void QueryingCategories()
{
    using (Northwind db = new())
    {
        ILoggerFactory loggerFactory = db.GetService<ILoggerFactory>();
        loggerFactory.AddProvider(new ConsoleLoggerProvider());

        WriteLine("Categories and how many products they have:");
        IQueryable<Category>? categories;
            //= db.Categories;//?
            //.Include(c => c.Products);
        db.ChangeTracker.LazyLoadingEnabled = false;
        Write("Enable Lazy loading? (Y/N)");
        bool eagerLoading = (ReadKey().Key == ConsoleKey.N);
        bool explicitLoading = false;
        WriteLine();
        if (eagerLoading)
        {
            categories = db.Categories
                .Include(c => c.Products);
        }
        else
        {
            categories = db.Categories;
            Write("Enable explicit loading? (Y/N)");
            explicitLoading = ReadKey().Key == ConsoleKey.Y;
            WriteLine();
        }

        if (categories is null)
        {
            WriteLine("No category found");
            return;
        }

        foreach (var category in categories)
        {
            if (explicitLoading)
            {
                Write($"Explicitly load products for {category.CategoryName}? (Y/N)");
                ConsoleKeyInfo key = ReadKey();
                WriteLine();

                if (key.Key == ConsoleKey.Y)
                {
                    CollectionEntry<Category, Product> products =
                        db.Entry(category)
                            .Collection(c2 => c2.Products);
                    
                    if (!products.IsLoaded) products.Load();
                }
            }

            WriteLine($"{category.CategoryName} " +
                      $"has {category.Products.Count} products");
        }
    }
}

static void FilteredIncludes()
{
    using Northwind db = new();

    ILoggerFactory loggerFactory = db.GetService<ILoggerFactory>();
    loggerFactory.AddProvider(new ConsoleLoggerProvider());

    Write("Enter a minimum for units in stock:");
    string unitsInStock = ReadLine() ?? "10";
    int stock = int.Parse(unitsInStock);

    IQueryable<Category>? categories = db.Categories
        .TagWith("Units filtered by stock")
        .Include(c => c.Products
            .Where(p => p.Stock >= stock));

    if (categories is null)
    {
        WriteLine("No category");
        return;
    }

    WriteLine($"ToQueryString: {categories.ToQueryString()}");

    foreach (var c in categories)
    {
        WriteLine($"{c.CategoryName} has {c.Products.Count} products");
        foreach (var p in c.Products)
        {
            WriteLine($"    {p.ProductName} has {p.Stock} units in stock");
        }
    }
}

static void QueryingProducts()
{
    using (Northwind db = new())
    {
        WriteLine("Products that cost more than a price highest at top");
        string? input;
        decimal price;
        do
        {
            Write("Enter a product price:");
            input = ReadLine();
        } while (!decimal.TryParse(input, out price));

        IQueryable<Product>? products = db.Products?
            .Where(p => p.Cost > price)
            .OrderByDescending(product => product.Cost);

        if (products is null)
        {
            WriteLine("No products found.");
            return;
        }

        foreach (var p in products)
        {
            WriteLine("{0}: {1} costs {2:$#,##0.00} and has {3} in stock",
                p.ProductId, p.ProductName, p.Cost, p.Stock);
        }
    }
}

static void QueryWithLike()
{
    using (Northwind db = new())
    {
        ILoggerFactory loggerFactory = db.GetService<ILoggerFactory>();
        loggerFactory.AddProvider(new ConsoleLoggerProvider());

        Write("Enter a part of product name:");
        string? input = ReadLine();

        IQueryable<Product>? products = db.Products?
            .Where(p =>
                EF.Functions
                    .Like(p.ProductName, $"%{input}%"));

        if (products is null)
        {
            WriteLine("no products");
        }

        foreach (var p in products)
        {
            WriteLine("{0} has {1} units in stock. Discontinued? {2}",
                p.ProductName, p.Stock, p.Discontinued);
        }
    }
}

static bool AddProduct(int categoryId, string productName, decimal? price)
{
    using (Northwind db = new())
    {
        Product p = new()
        {
            CategoryId = categoryId,
            ProductName = productName,
            Cost = price
        };

        db.Products.Add(p);
        int affected = db.SaveChanges();
        return (affected == 1);
    }
}

static void ListProducts()
{
    using (Northwind db = new())
    {
        WriteLine("{0, -3} {1, -35} {2, 8} {3, 5} {4}",
            "Id", "Product Name", "Cost", "Stock", "Disc");

        foreach (var p in db.Products
                     .OrderByDescending(product => product.Cost))
        {
            WriteLine("{0:000} {1, -35} {2,8:$#,##0.00} {3, 5} {4}",
                p.ProductId,
                p.ProductName,
                p.Cost,
                p.Stock,
                p.Discontinued);
        }
    }
}

static bool IncreaseProductPrice(string productNameStartWith, decimal amount)
{
    using (Northwind db = new())
    {
        Product updateProduct = db.Products
            .First(p => p.ProductName.StartsWith(productNameStartWith));

        updateProduct.Cost += amount;

        int affected = db.SaveChanges();
        return (affected == 1);
    }
}

static int DeleteProducts(string productNameStartWith)
{
    using (Northwind db = new())
    {
        using (IDbContextTransaction t = db.Database.BeginTransaction())
        {
            WriteLine("Transaction Isolation Level: {0}"
                , t.GetDbTransaction().IsolationLevel);

            IQueryable<Product>? products = db.Products?
                .Where(p => p.ProductName.StartsWith(productNameStartWith));

            if (products is null)
            {
                WriteLine("No products found");
                return 0;
            }

            db.Products.RemoveRange(products);

            int affected = db.SaveChanges();
            
            t.Commit();

            return affected;
        }
    }
}