using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigration;
public class DbInitializer
{
    public static void Initialize(BloggingContext context)
    {
        context.Database.EnsureCreated();

        if (context.Blogs.Any())
        {
            return;
        }

        var blogs = new Blog[]
        {
            new Blog { Name = "My Blog" }
        };
        context.Blogs.AddRange(blogs);
        context.SaveChanges();

        var posts = new Post[]
        {
            new Post { BlogId = 1
                , Title = "My First post"
                , Content = "Hi! this is my first post" }
        };
        context.Posts.AddRange(posts);
        context.SaveChanges();
    }
}
