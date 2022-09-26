using Microsoft.EntityFrameworkCore;

namespace CoursesAndStudents;

public class Academy : DbContext
{
    public DbSet<Student>? Students { get; set; }
    public DbSet<Course>? Courses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connection = "Data Source = LUNATPC\\MSSQLDEV;" +
                            "Initial Catalog = Academy;" +
                            "Integrated Security=true;";
        optionsBuilder.UseSqlServer(connection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .Property(s => s.LastName)
            .HasMaxLength(30)
            .IsRequired();

        var alice = new Student
        {
            StudentId = 1,
            FirstName = "Alice",
            LastName = "Jones",
        };
        var bob = new Student
        {
            StudentId = 2,
            FirstName = "Bob",
            LastName = "Smith",
        };
        var laura = new Student
        {
            StudentId = 3,
            FirstName = "Laura",
            LastName = "Hunt",
        };

        var csharp = new Course
        {
            CourseId = 1,
            Title = "C# 10 and .NET 6"
        };
        var web = new Course
        {
            CourseId = 2,
            Title = "Web Development"
        };
        var php = new Course
        {
            CourseId = 3,
            Title = "PHP for Beginners"
        };

        modelBuilder.Entity<Course>()
            .HasData(csharp, web, php);
        modelBuilder.Entity<Student>()
            .HasData(alice, bob, laura);

        modelBuilder.Entity<Course>()
            .HasMany(c => c.Students)
            .WithMany(s => s.Courses)
            .UsingEntity(e => e.HasData(
                new { CoursesCourseId = 1, StudentsStudentId = 1 },
                new { CoursesCourseId = 1, StudentsStudentId = 2 },
                new { CoursesCourseId = 1, StudentsStudentId = 3 },
                new { CoursesCourseId = 2, StudentsStudentId = 2 },
                new { CoursesCourseId = 3, StudentsStudentId = 3 }
            ));
    }
}