
using System.Xml.Linq;
using LinqWithEFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Models;

//FilterAndSort();
//JoinCategoriesAndProducts();
//GroupJoinCategoriesAndProducts();
//AggregateProducts();
//CustomExtensionMethods();
//OutputProductsAsXml();
ProcessSettings();

static void FilterAndSort()
{
    using (Northwind db = new())
    {
        DbSet<Product> allProducts = db.Products;

        IQueryable<Product> processedProducts =
            allProducts.ProcessSequence();

        IQueryable<Product> filteredProducts =
            //allProducts
            processedProducts
                .Where(product => product.UnitPrice < 10M);

        IOrderedQueryable<Product> sortedAndFilteredProducts =
            filteredProducts.OrderByDescending(product => product.UnitPrice);

        var projectedProducts = sortedAndFilteredProducts
            .Select(product => new
            {
                product.ProductId,
                product.ProductName,
                product.UnitPrice
            });
        
        Console.WriteLine("Products that cost less than 10$:");

        foreach (var p in projectedProducts)
        {
            Console.WriteLine($"{p.ProductId}: {p.ProductName} costs" +
                              $" {p.UnitPrice}");
        }

        Console.WriteLine();
    }
}

static void JoinCategoriesAndProducts()
{
    using (Northwind db = new())
    {
        // join every product to its category
        var queryJoin =
            db.Categories
                .Join(
                    inner: db.Products,
                    outerKeySelector: category => category.CategoryId,
                    innerKeySelector: product => product.CategoryId,
                    resultSelector: (c, p) =>
                        new
                        {
                            c.CategoryName,
                            p.ProductName,
                            p.ProductId
                        })
                .OrderBy(cp => cp.CategoryName);

        foreach (var item in queryJoin)
        {
            Console.WriteLine($"{item.ProductId}: " +
                              $"{item.ProductName} " +
                              $"is in {item.CategoryName}");
        }
    }
}

static void GroupJoinCategoriesAndProducts()
{
    using Northwind db = new();

    // group all products by their category to return 8 matches
    var queryGroup = db.Categories
        .AsEnumerable()
        .GroupJoin(
            inner: db.Products,
            outerKeySelector: category => category.CategoryId,
            innerKeySelector: product => product.CategoryId,
            resultSelector: (c, matchingProducts) =>
                new
                {
                    c.CategoryName,
                    Products= matchingProducts
                        .OrderBy(p => p.ProductName)
                });

    foreach (var category in queryGroup)
    {
        Console.WriteLine($"{category.CategoryName} " +
                          $"has {category.Products.Count()} products:");

        foreach (var product in category.Products)
        {
            Console.WriteLine($"    {product.ProductName}");
        }
    }
}

static void AggregateProducts()
{
    using (Northwind db = new())
    {
        Console.WriteLine("{0, -25} {1, 10} {2}"
            , "Product count:"
            , db.Products.Count()
            , "!!!");

        Console.WriteLine("{0, -25} {1, 10:$#,##0.00}"
            , "Highest product price:"
            , db.Products.Max(p => p.UnitPrice));

        Console.WriteLine("{0, -25} {1, 10:N0}"
            , "Sum of units in stock:"
            , db.Products.Sum(p => p.UnitsInStock));

        Console.WriteLine("{0, -25} {1, 10:N0}"
            , "Sum of units on order:"
            , db.Products.Sum(p => p.UnitsOnOrder));

        Console.WriteLine("{0, -25} {1, 10:$#,##0.00}"
            , "Average unit price:"
            , db.Products.Average(p => p.UnitPrice));

        Console.WriteLine("{0, -25} {1, 10:$#,##0.00}"
            , "Value in stock:"
            , db.Products.Sum(p => p.UnitPrice * p.UnitsInStock));
    }
}

static void CustomExtensionMethods()
{
    using (Northwind db = new())
    {
        Console.WriteLine("Mean units in stock: {0:N0}:"
            , db.Products.Average(p => p.UnitsInStock));

        Console.WriteLine("Mean unit price: {0:$#,##0.00}:"
            , db.Products.Average(p => p.UnitPrice));

        Console.WriteLine("Median units in stock: {0:N0}:"
            , db.Products.Median(p => p.UnitsInStock) );

        Console.WriteLine("Median unit price: {0:$#,##0.00}:"
            , db.Products.Median(p => p.UnitPrice));

    }
}

static void OutputProductsAsXml()
{
    using (Northwind db = new())
    {
        Product[] productsArray = db.Products.ToArray();

        XElement xml = new ("products",
            from p in productsArray
            select new XElement("product",
                new XAttribute("id", p.ProductId),
                new XAttribute("price", p.UnitPrice),
                new XElement("name", p.ProductName)));

        Console.WriteLine(xml.ToString());
    }
}

static void ProcessSettings()
{
    XDocument doc = XDocument.Load("settings.xml");
    var appSettings = doc.Descendants("appSettings")
        .Descendants("add")
        .Select(node => new
        {
            Key = node.Attribute("key")?.Value,
            Value = node.Attribute("value")?.Value
        }).ToArray();

    foreach (var item in appSettings)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}