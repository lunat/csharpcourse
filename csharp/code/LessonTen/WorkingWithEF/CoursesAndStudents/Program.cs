using static System.Console;
using CoursesAndStudents;
using Microsoft.EntityFrameworkCore;

using (Academy a = new())
{
    bool deleted = await a.Database.EnsureDeletedAsync();
    WriteLine($"Database deleted: {deleted}");

    bool created = await a.Database.EnsureCreatedAsync();
    WriteLine($"Database created {created}");
    WriteLine("SQL script used to created database;");
    WriteLine(a.Database.GenerateCreateScript());

    foreach (var student in a.Students
                 .Include(s => s.Courses))
    {
        WriteLine($"{student.FirstName} {student.LastName}" +
                  $" attends the following {student.Courses.Count} courses");

        foreach (var course in student.Courses)
        {
            WriteLine($"    {course.Title}");
        }
    }
}