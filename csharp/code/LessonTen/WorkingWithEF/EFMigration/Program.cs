using EFMigration;

using var db = new BloggingContext();

DbInitializer.Initialize(db);

// asking for a new blog
Console.WriteLine("Enter a name for a new blog:");
var name = Console.ReadLine();

// new blog creation
var blog = new Blog { Name = name};
db.Blogs.Add(blog);
db.SaveChanges();

// display all blogs in database
var query = (from b in db.Blogs
    orderby b.Name
    select b).ToList();

Console.WriteLine("All blogs in database:");
foreach (var item in query)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("Press any key to exit..");
Console.ReadKey();